using OneOf;

namespace FluentAssertions.OneOf.Tests
{
    public class Some<T>
    {
        public T Value { get; set; } = default!;
    }

    public class None
    {

    }
}
