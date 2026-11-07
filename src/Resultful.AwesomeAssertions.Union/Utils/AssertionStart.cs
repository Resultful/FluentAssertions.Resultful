#if FLUENTASSERTIONS
namespace FluentAssertions.Union.Utils
#else
namespace Resultful.AwesomeAssertions.Union.Utils
#endif
{
    /// <summary>
    /// Starts an assertion with its reason. This is the one call that differs between the two flavors:
    /// AwesomeAssertions (and FluentAssertions 8) chain through <c>AssertionChain</c>, FluentAssertions 7 through
    /// <c>Execute.Assertion</c>. Both return a type with <c>ForCondition</c> and <c>FailWith</c>, named here by the
    /// <c>AssertionContext</c> alias the build defines.
    /// </summary>
    public static class AssertionStart
    {
        public static AssertionContext BecauseOf(string because, object[] becauseArgs)
#if FLUENTASSERTIONS
            => Execute.Assertion.BecauseOf(because, becauseArgs);
#else
            => AssertionChain.GetOrCreate().BecauseOf(because, becauseArgs);
#endif
    }
}
