using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace FluentAssertions.DU
{
    public static class DUAssertionExtensions
    {
        public static AndConstraint<TResult> BeCase<TResult>(this ObjectAssertions assertionContext, string because, object[] becauseArgs)
        {
            void Assert<T>(T value)
            {
                AssertionUtils.CheckItemHelper<TResult>(Execute.Assertion.BecauseOf(because, becauseArgs),
                    value.Create());
            }

            var result = assertionContext.Subject.GetDUResult<TResult>(Assert);

            return new AndConstraint<TResult>(result);
        }
    }
}
