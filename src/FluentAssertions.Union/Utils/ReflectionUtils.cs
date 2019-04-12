using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions.Union.Models;

namespace FluentAssertions.Union.Utils
{
    internal static class ReflectionUtils
    {
        internal static IEnumerable<MethodInfo> GetMethods(this Type type, string name)
            => type
                .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                .Where(x => x.Name == name);

        internal static IEnumerable<UnionMethodInfo> GetMatchMethods(this Type type)
            => type
                .GetMethods("Match")
                .Select(x => GetMatchableTypes(x, false))
                .Where(x => x.CaseTypes != null);


        internal static IEnumerable<UnionMethodInfo> GetSwitchMethods(this Type type)
            => type
                .GetMethods("Switch")
                .Select(x => GetMatchableTypes(x, true))
                .Where(x => x.CaseTypes != null);


        internal static UnionResult GetUnionResult<TResult>(this TypeValuePair item, Action<List<UnionMethodInfo>> failedToFind)
        {
            var resultType = typeof(TResult);
            var methodInfo = item.Type.GetAppropriateMethod(resultType, out var possibilities);

            if(methodInfo == null)
            {
                failedToFind(possibilities);
            }
            var result = item.Value.GetUnionResult(methodInfo);

            return new UnionResult(methodInfo, result);
        }


        //Action<int> wrappedFunction -- this arg has been removed because I haven't figured out the generics to inline the assertions being tested
        internal static TypeValuePair GetUnionResult(this object item, UnionMethodInfo unionMethodData)
        {
            if (unionMethodData.IsSwitch)
            {
                TypeValuePair closureResult  = null;

                void GetSwitch<TValue>(TValue value)
                    => closureResult = new TypeValuePair(typeof(TValue), value);

                void GetSwitchOptional()
                    => throw new Exception("Optional parameter cannot resolve a value");

                var switchMainArgs = unionMethodData.CaseTypes.Select(x => MethodUtils.MakeAction(GetSwitch, x));

                var switchFinalArgs = switchMainArgs.Concat(
                        unionMethodData.OptionalLast
                            ? new[] { MethodUtils.MakeAction(GetSwitchOptional) }
                            : new object[0])
                    .ToArray();
                 unionMethodData.Method.Invoke(item, switchFinalArgs);

                return closureResult;
            }

            TypeValuePair GetMatch<TValue>(TValue value)
                => new TypeValuePair(typeof(TValue), value);

            TypeValuePair GetMatchOptional()
                => throw new Exception("Optional parameter cannot resolve a value");

            var mainArgs = unionMethodData.CaseTypes.Select(x => MethodUtils.MakeMatchArg(GetMatch, x));

            var finalArgs = mainArgs.Concat(
                    unionMethodData.OptionalLast
                        ? new[] { MethodUtils.MakeFunc(GetMatchOptional) }
                        : new object[0])
                .ToArray();
            return (TypeValuePair)unionMethodData.Method
                .MakeGenericMethod(typeof(TypeValuePair))
                .Invoke(item, finalArgs);
        }

        internal static UnionMethodInfo GetAppropriateMethod(this Type type, Type expectedType, out List<UnionMethodInfo> possibilities)
            => GetAppropriateMethod(type, out possibilities,
                    x => x.CaseTypes.Any(y => y.IsAssignableFrom(expectedType)));


        internal static UnionMethodInfo GetAppropriateMethod(this Type type, out List<UnionMethodInfo> possibilities, Func<UnionMethodInfo, bool> filter)
        {
            possibilities = type
                .GetMatchMethods()
                .Concat(type.GetSwitchMethods())
                .Where(filter)
                .ToList();

            return possibilities
                .FirstOrDefault();
        }

        internal static string PrettyPrint(this Type type)
        {
            var genericArguments = type.GetGenericArguments();
            if (!genericArguments.Any())
            {
                return type.Name;
            }
            var genericName = type.Name.Substring(0, type.Name.IndexOf("`", StringComparison.Ordinal));
            return $"{genericName}<{string.Join(",", genericArguments.Select(PrettyPrint))}>";
        }


        internal static UnionMethodInfo GetMatchableTypes(this MethodInfo methodInfo, bool isSwitch)
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
                    return new UnionMethodInfo(types, methodInfo, optional, isSwitch);
                }
            }
            return new UnionMethodInfo(null, methodInfo, false, isSwitch);
        }
    }
}
