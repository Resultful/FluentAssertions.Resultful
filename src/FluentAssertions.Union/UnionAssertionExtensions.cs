using System;
using FluentAssertions.Execution;
using FluentAssertions.Numeric;
using FluentAssertions.Primitives;
using FluentAssertions.Union.Models;
using FluentAssertions.Union.Utils;

namespace FluentAssertions.Union
{
    public static class UnionAssertionExtensions
    {
        public static AndConstraint<TResult> ShouldBeCase<TResult>(this object item, string because = "", params object[] becauseArgs)
        {
            var value = item.CreateFromObject();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            var result = value.GetUnionResult<TResult>(items => AssertionUtils.AssertNoMethod<TResult>(scope, value.Type, items));

            var assertedResult = AssertionUtils.CheckItemHelper<TResult>(scope, result.TypeValuePair, result.MethodInfo);

            return new AndConstraint<TResult>(assertedResult);
        }

        public static AndConstraint<TResultConstraint> ShouldBeCase<TResult, TResultConstraint>(this object item, 
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if (assertionFunc == null) throw new ArgumentNullException(nameof(assertionFunc));
            var result = item.ShouldBeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }

        public static AndConstraint<None> ShouldBeNone(this object item, string because = "", params object[] becauseArgs)
        {
            var value = item.CreateFromObject();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            var result = value.GetUnionResult<None>(items => AssertionUtils.AssertNoMethod<None>(scope, value.Type, items));

            var assertedResult = AssertionUtils.CheckItemHelper<None>(scope, result.TypeValuePair, result.MethodInfo);

            return new AndConstraint<None>(assertedResult);
        }


        public static AndConstraint<TResultConstraint> ShouldBeNone<TResultConstraint>(this object item,
            Func<TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if (assertionFunc == null) throw new ArgumentNullException(nameof(assertionFunc));
            item.ShouldBeNone(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc());
        }
    }
}
