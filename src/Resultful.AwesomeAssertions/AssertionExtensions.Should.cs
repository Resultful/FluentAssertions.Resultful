using Resultful;

#if FLUENTASSERTIONS
namespace FluentAssertions.Resultful
#else
namespace Resultful.AwesomeAssertions
#endif
{
    public static partial class AssertionExtensions
    {
        public static ResultAssertions<T, TError> Should<T, TError>(this Result<T, TError> item)
            => new ResultAssertions<T, TError>(item);
    }
}
