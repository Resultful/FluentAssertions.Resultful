using System;
using OneOf;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;
using FluentAssertions.Union.Models;
using FluentAssertions.Union.Utils;

namespace FluentAssertions.OneOf
{
    public class OneOfAssertions<T0>
    {
        public OneOfAssertions(OneOf<T0> item)
        {
            Subject = item;
        }

        public OneOf<T0> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1>
    {
        public OneOfAssertions(OneOf<T0, T1> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2>
    {
        public OneOfAssertions(OneOf<T0, T1, T2> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2, T3>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2, T3, T4>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7> Subject { get; }

        public AndConstraint<TResult> BeCase<TResult>(
            string because = "", params object[] becauseArgs)
        {
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<TResult>(scope.Assert<TResult>(value));
        }

        public AndConstraint<TResultConstraint> BeCase<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = BeCase<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

}
