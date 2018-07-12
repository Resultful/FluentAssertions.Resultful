using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FluentAssertions;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;

namespace FluentAssertions.DU
{
    public static class AssertionUtils
    {

        internal static TResult CheckItemHelper<TResult>(AssertionScope scope, TypeValuePair typeValuePair,
            params Type[] givenTypes)
        {
            var itemType = typeValuePair.Type;
            var expectedType = typeof(TResult);
            var expectedTypePretty = ReflectionUtils.PrettyPrint(expectedType);
            var givenTypesPretty = string.Join(", ", givenTypes.Select(ReflectionUtils.PrettyPrint));

            scope
                .ForCondition(givenTypes.Contains(expectedType))
                .FailWith("Func should be one of {0} but found {1} instead.",
                    givenTypesPretty, expectedTypePretty);

            scope
                .ForCondition(expectedType.IsAssignableFrom(itemType))
                .FailWith("Func should be assignable to {0} but found {1} which cannot be assigned to",
                    expectedTypePretty, ReflectionUtils.PrettyPrint(itemType));

            return (TResult)typeValuePair.Value;
        }

        internal static TResult CheckItemHelper<TItem, TResult>(AssertionScope scope, TItem element, params Type[] givenTypes)
            => CheckItemHelper<TResult>(scope, element.Create(), givenTypes);

        internal static void BeEquivalentTo<TExpectation, TSubject>(TSubject subject, TExpectation expectation, string because = "",
            params object[] becauseArgs)
        {
            BeEquivalentTo(subject, expectation, config => config, because, becauseArgs);
        }

        internal static void BeEquivalentTo<TExpectation, TSubject>(TSubject subject, TExpectation expectation,
            Func<EquivalencyAssertionOptions<TExpectation>, EquivalencyAssertionOptions<TExpectation>> config,
            string because = "",
            params object[] becauseArgs)
        {
            var options = config(AssertionOptions.CloneDefaults<TExpectation>());
            var context = new EquivalencyValidationContext
            {
                Subject = subject,
                Expectation = expectation,
                CompileTimeType = typeof(TExpectation),
                Because = because,
                BecauseArgs = becauseArgs,
                Tracer = options.TraceWriter
            };
            new EquivalencyValidator(options).AssertEquality(context);
        }
    }
}
