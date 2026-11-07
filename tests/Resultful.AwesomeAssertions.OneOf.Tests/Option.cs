using OneOf;

namespace Resultful.AssertionTests.OneOf
{
    public class Some<T>
    {
        public T Value { get; set; } = default!;
    }

    public class None
    {

    }
}
