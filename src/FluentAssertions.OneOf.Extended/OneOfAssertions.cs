using System;
using OneOf;
using FluentAssertions.DU;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;

namespace FluentAssertions.OneOf
{
    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25, T26>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25, T26, T27>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25, T26, T27, T28>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25, T26, T27, T28, T29,
        T30>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28, T29,
            T30> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28, T29,
            T30> Subject { get; }

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

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
        T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
        T20, T21, T22, T23, T24, T25, T26, T27, T28, T29,
        T30, T31>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28, T29,
            T30, T31> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11, T12, T13, T14, T15, T16, T17, T18, T19,
            T20, T21, T22, T23, T24, T25, T26, T27, T28, T29,
            T30, T31> Subject { get; }

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
