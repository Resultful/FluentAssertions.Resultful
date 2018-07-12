using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentAssertions.DU
{ 

    internal static class ReflectionUtils
    {
        internal static IEnumerable<MethodInfo> GetMethods(this Type type, string name)
            => type
                .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                .Where(x => x.Name == name);

        internal static IEnumerable<DuMethodInfo> GetMatchMethods(this Type type)
            => type
                .GetMethods("Match")
                .Select(x => GetMatchableTypes(x, false))
                .Where(x => x.CaseTypes != null);


        internal static IEnumerable<DuMethodInfo> GetSwitchMethods(this Type type)
            => type
                .GetMethods("Switch")
                .Select(x => GetMatchableTypes(x, true))
                .Where(x => x.CaseTypes != null);

        internal static TResult GetDUResult<TResult>(this object item, Action<int> actionMethodPair)
        {
            var method = item.GetType().GetAppropriateMethod(typeof(TResult));

            var result = item.GetDUResult(method, actionMethodPair);

            return (TResult)result.Value;
        }


        internal static TypeValuePair GetDUResult(this object item, DuMethodInfo duMethodData, Action<int> wrappedFunction)
        {
            if (duMethodData.IsSwitch)
            {
                TypeValuePair closureResult  = null;

                void GetSwitch<TValue>(TValue value)
                {
                    var method = (Action<TValue>)wrappedFunction.MakeAction(typeof(TValue));

                    method(value);
                    closureResult = new TypeValuePair(typeof(TValue), value);
                }

                void GetSwitchOptional()
                {
                    throw new Exception("Optional parameter cannot resolve a value");
                }

                var switchMainArgs = duMethodData.CaseTypes.Select(x => MethodUtils.MakeAction(GetSwitch, x));

                var switchFinalArgs = switchMainArgs.Concat(
                        duMethodData.OptionalLast
                            ? new[] { MethodUtils.MakeAction(GetSwitchOptional) }
                            : new object[0])
                    .ToArray();
                 duMethodData.Method.Invoke(item, switchFinalArgs);

                return closureResult;
            }

            TypeValuePair GetMatch<TValue>(TValue value)
            {
                var genericMethod = (Action<TValue>)wrappedFunction.MakeAction(typeof(TValue));

                genericMethod.Invoke(value);

                return new TypeValuePair(typeof(TValue), value);
            }

            TypeValuePair GetMatchOptional()
            {
                throw new Exception("Optional parameter cannot resolve a value");
            }

            var mainArgs = duMethodData.CaseTypes.Select(x => MethodUtils.MakeMatchArg(GetMatch, x));

            var finalArgs = mainArgs.Concat(
                    duMethodData.OptionalLast
                        ? new[] { MethodUtils.MakeFunc(GetMatchOptional) }
                        : new object[0])
                .ToArray();
            return (TypeValuePair)duMethodData.Method
                .MakeGenericMethod(typeof(TypeValuePair))
                .Invoke(item, finalArgs);
        }

        internal static DuMethodInfo GetAppropriateMethod(this Type type, Type expectedType)
            => type
                .GetMatchMethods()
                .Concat(type.GetSwitchMethods())
                .Where(x =>
                {
                    return x.CaseTypes.Any(y => y.IsAssignableFrom(expectedType));
                })
                .FirstOrDefault();


        internal static DuMethodInfo GetAppropriateMethod(this Type type)
            => type
                .GetMatchMethods()
                .Concat(type.GetSwitchMethods())
                .FirstOrDefault();

        internal static string PrettyPrint(Type type)
        {
            var genericArguments = type.GetGenericArguments();
            if (!genericArguments.Any())
            {
                return type.Name;
            }
            var genericName = type.Name.Substring(0, type.Name.IndexOf("`", StringComparison.Ordinal));
            return $"{genericName}<{string.Join(",", genericArguments.Select(PrettyPrint))}>";
        }


        internal static DuMethodInfo GetMatchableTypes(this MethodInfo methodInfo, bool isSwitch)
        {
            if ((methodInfo.IsGenericMethod &&
                methodInfo.IsGenericMethodDefinition &&
                methodInfo.ReturnType.IsGenericParameter) || isSwitch)
            {
                var retPara = methodInfo.ReturnType;
                var paramters = methodInfo.GetParameters();
                var parametersLegth = paramters.Length;

                var optional = false;
                var i = 1;
                if (paramters.All(
                    x =>
                    {
                        bool ParameterMatch(Type givenType, out bool hasOptional)
                        {
                            hasOptional = false;
                            var genericType = givenType;
                            if (genericType.IsGenericType)
                            {
                                genericType = genericType.GetGenericTypeDefinition();
                            }
                            if (i == parametersLegth)
                            {
                                //If last element does not accept a type into the method
                                switch (isSwitch)
                                {
                                    case true:
                                        hasOptional = genericType == typeof(Action);
                                        return hasOptional || genericType == typeof(Action<>);
                                    case false:
                                        hasOptional = genericType == typeof(Func<>);
                                        return hasOptional || genericType == typeof(Func<,>);
                                }
                            }

                            switch (isSwitch)
                            {
                                case true:
                                    return genericType == typeof(Action<>);
                                default: //case false:
                                    return genericType == typeof(Func<,>);
                            }
                        }

                        var typeMatches = ParameterMatch(x.ParameterType,
                            out var caseIsOptional);

                        i++;

                        if (caseIsOptional)
                        {
                            optional = true;
                        }

                        if (x.IsOut || x.IsIn || x.HasDefaultValue || !typeMatches)
                        {
                            return false;
                        }
                        var funcTypes = x.ParameterType.GenericTypeArguments;

                        var result = isSwitch
                            ? retPara == typeof(void)
                            : funcTypes[optional ? 0 : 1] == retPara;
                        return result;
                    }))
                {
                    var itemsToGet = optional ? parametersLegth - 1 : parametersLegth;
                    var types = paramters
                        .TakeWhile((_, index) => index < itemsToGet)
                        .Select(x => x.ParameterType.GenericTypeArguments[0])
                        .ToArray();
                    return new DuMethodInfo(types, methodInfo, optional, isSwitch);
                }
            }
            return new DuMethodInfo(null, methodInfo, false, isSwitch);
        }
    }
}
