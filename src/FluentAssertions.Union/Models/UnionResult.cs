using System;

namespace FluentAssertions.Union.Models
{
    public class UnionResult<T>
    {


        internal UnionResult(UnionMethodInfo methodInfo, T value)
        {
            MethodInfo = methodInfo;
            Value = value;
        }

        public UnionMethodInfo MethodInfo { get; }
        public T Value { get; }

        public void Deconstruct(out T value, out object methodInfo)
        {
            value = Value;
            methodInfo = MethodInfo;
        }
    }

    public class UnionResult
    {


        internal UnionResult(UnionMethodInfo methodInfo, TypeValuePair typeValuePair)
        {
            MethodInfo = methodInfo;
            TypeValuePair = typeValuePair;
        }

        public UnionMethodInfo MethodInfo { get; }
        public TypeValuePair TypeValuePair { get; }

        public void Deconstruct(out TypeValuePair typeValuePair, out object methodInfo)
        {
            typeValuePair = TypeValuePair;
            methodInfo = MethodInfo;
        }


        public static UnionResult<TResult> Get<TResult>()
        {
            throw new NotImplementedException();
        }
    }

}
