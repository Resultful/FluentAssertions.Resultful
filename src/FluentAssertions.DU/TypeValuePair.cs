using System;

namespace FluentAssertions.DU
{
    internal class TypeValuePair
    {
        public TypeValuePair(Type type, object value)
        {
            Type = type;
            Value = value;
        }

        public Type Type { get; }
        public object Value { get; }

        public void Deconstruct(out Type type, out object value)
        {
            type = Type;
            value = Value;
        }
    }

    internal static class TypeValuePairExtensions
    {
        public static TypeValuePair Create<T>(this T value)
        {
            return new TypeValuePair(typeof(T), value);
        }
    }
}
