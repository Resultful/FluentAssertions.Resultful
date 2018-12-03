using System;

namespace FluentAssertions.DU
{
    public class TypeValuePair
    {
        internal TypeValuePair(Type type, object value)
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

    public static class TypeValuePairExtensions
    {
        public static TypeValuePair Create<T>(this T value)
            => new TypeValuePair(typeof(T), value);

        public static TypeValuePair CreateFromObject(this object item)
            => new TypeValuePair(item.GetType(), item);
    }
}
