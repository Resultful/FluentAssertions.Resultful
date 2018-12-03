using System;

namespace FluentAssertions.DU
{
    public class DuResult<T>
    {


        internal DuResult(DuMethodInfo methodInfo, T value)
        {
            MethodInfo = methodInfo;
            Value = value;
        }

        public DuMethodInfo MethodInfo { get; }
        public T Value { get; }

        public void Deconstruct(out T value, out object methodInfo)
        {
            value = Value;
            methodInfo = MethodInfo;
        }
    }

    public class DuResult
    {


        internal DuResult(DuMethodInfo methodInfo, TypeValuePair typeValuePair)
        {
            MethodInfo = methodInfo;
            TypeValuePair = typeValuePair;
        }

        public DuMethodInfo MethodInfo { get; }
        public TypeValuePair TypeValuePair { get; }

        public void Deconstruct(out TypeValuePair typeValuePair, out object methodInfo)
        {
            typeValuePair = TypeValuePair;
            methodInfo = MethodInfo;
        }


        public static DuResult<TResult> Get<TResult>()
        {
            throw new NotImplementedException();
        }
    }

}
