using System;
using OneOf;
using static FluentAssertions.OneOf.AssertionHelpers;

namespace FluentAssertions.OneOf
{
    public class OneOfAssertions<T0>
    {
        public OneOfAssertions(OneOf<T0> item)
        {
            Subject = item;
        }

        public OneOf<T0> Subject { get; }

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0));

            var result = Subject.Match(
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1));

            var result = Subject.Match(
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

    public class OneOfAssertions<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public OneOfAssertions(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> item)
        {
            Subject = item;
        }

        public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> Subject { get; }

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25), typeof(T26));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25), typeof(T26), typeof(T27));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25), typeof(T26), typeof(T27), typeof(T28));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25), typeof(T26), typeof(T27), typeof(T28), typeof(T29));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25), typeof(T26), typeof(T27), typeof(T28), typeof(T29),
                    typeof(T30));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
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

        public AndConstraint<TResult> Be<TResult>(
            string because = "", params object[] becauseArgs)
        {
            TResult CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, TResult>(element, becauseArgs, because,
                    typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4),
                    typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9),
                    typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14),
                    typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19),
                    typeof(T20), typeof(T21), typeof(T22), typeof(T23), typeof(T24),
                    typeof(T25), typeof(T26), typeof(T27), typeof(T28), typeof(T29),
                    typeof(T30), typeof(T31));

            var result = Subject.Match(
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem,
                CheckItem, CheckItem, CheckItem, CheckItem
            );
            return new AndConstraint<TResult>(result);
        }

        public AndConstraint<TResultConstraint> Be<TResult, TResultConstraint>(
            Func<TResult, TResultConstraint> assertionFunc,
            string because = "", params object[] becauseArgs)
        {
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }
            var result = Be<TResult>(because, becauseArgs);
            return new AndConstraint<TResultConstraint>(assertionFunc(result.And));
        }
    }

}
