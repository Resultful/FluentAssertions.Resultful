using System;
using FluentAssertions.DU;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace FluentAssertions
{
    public static class DuAssertionExtensions
    {
        public static AndConstraint<TResult> BeCase<TResult>(this ObjectAssertions assertionContext, string because = "", params object[] becauseArgs)
        {
            var value = assertionContext.Subject.CreateFromObject();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            var result = value.GetDUResult<TResult>(items => AssertionUtils.AssertNoMethod<TResult>(scope, value.Type, items));

            var assertedResult = AssertionUtils.CheckItemHelper<TResult>(scope, result.TypeValuePair, result.MethodInfo.CaseTypes);

            return new AndConstraint<TResult>(assertedResult);
        }


        public static AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(this ObjectAssertions assertionContext, 
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if (assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = assertionContext.BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }
}
