using FluentAssertions.Resultful;
using Resultful;

namespace FluentAssertions.Resultful
{
    public static partial class AssertionExtensions
    {
        public static ResultAssertions<T, TError> Should<T, TError>(this Result<T, TError> item)
            => new ResultAssertions<T, TError>(item);
    }
}
