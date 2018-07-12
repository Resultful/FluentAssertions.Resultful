using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentAssertions.DU
{
    public static class MethodUtils
    {
        static internal object MakeAction(this Action<int> func, Type type)
        {
            var method = func.Method;
            var genericMethod = method.GetGenericMethodDefinition();
            var concreteMethod = genericMethod.MakeGenericMethod(type);
            var newType = typeof(Action<>).MakeGenericType(type);

            var invoker = concreteMethod.GetType().GetMethods("Invoke").FirstOrDefault(x => x.GetParameters().Length == 2);

            var parameterExpr = Expression.Parameter(type, "p");
            var constantExpr = Expression.Constant(concreteMethod, typeof(MethodInfo));

            var parameters = new Expression[]
            {
                Expression.Constant(func.Target),
                Expression.NewArrayInit(typeof(object), Expression.Convert(parameterExpr, typeof(object)))
            };
            var body = Expression.Call(constantExpr, invoker, parameters);
            var lambda = Expression.Lambda(newType, body, parameterExpr);
            return lambda.Compile();
        }

        static internal object MakeAction(this Action func)
        {
            return func;
        }

        static internal object MakeMatchArg(Func<int, TypeValuePair> func, Type type)
        {
            var method = func.Method;
            var genericMethod = method.GetGenericMethodDefinition();
            var concreteMethod = genericMethod.MakeGenericMethod(type);
            var newType = typeof(Func<,>).MakeGenericType(type,typeof(TypeValuePair));

            var invoker = concreteMethod.GetType().GetMethods("Invoke").FirstOrDefault(x => x.GetParameters().Length == 2);

            var parameterExpr = Expression.Parameter(type, "p");
            var constantExpr = Expression.Constant(concreteMethod, typeof(MethodInfo));

            var parameters = new Expression[]
            {
                Expression.Constant(func.Target),
                Expression.NewArrayInit(typeof(object),
                    Expression.Convert(parameterExpr, typeof(object)))
            };
            var body = Expression.Convert(Expression.Call(constantExpr, invoker, parameters), typeof(TypeValuePair));
            var lambda = Expression.Lambda(newType, body, parameterExpr);
            return lambda.Compile();
        }

        static internal object MakeFunc(Func<TypeValuePair> func)
        {
            return func;
        }


    }
}
