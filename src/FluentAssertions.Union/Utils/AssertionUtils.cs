using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;
using FluentAssertions.Union.Models;

namespace FluentAssertions.Union.Utils
{
    public static class AssertionUtils
    {
        internal static void AssertNoMethod<TResult>(AssertionScope scope, Type assertionType, List<UnionMethodInfo> otherPossibilities)
        {
            if (otherPossibilities.Any())
            {
                string Print(UnionMethodInfo info) => string.Join(", ", info.CaseTypes.Select(ReflectionUtils.PrettyPrint));
                var prettyPrintedCases = string.Join(",", otherPossibilities.Select(x => $"{{{Print(x)}}}"));

                scope.FailWith("Multiple Discriminated Union methods found {0}, method types listed {1} non match {2}",
                    assertionType.PrettyPrint(), prettyPrintedCases, typeof(TResult).PrettyPrint());
            }

            scope.FailWith("Unable to find any Discriminated Union method on type {0} for expected type {1}", assertionType.PrettyPrint(), typeof(TResult).PrettyPrint());
        }


        public static TResult Assert<TResult>(this AssertionScope scope, TypeValuePair value)
        {
            var result = value.GetUnionResult<TResult>(items => AssertNoMethod<TResult>(scope, value.Type, items));

            var assertedResult = CheckItemHelper<TResult>(scope, result.TypeValuePair, result.MethodInfo.CaseTypes);

            return assertedResult;
        }

        internal static TResult CheckItemHelper<TResult>(AssertionScope scope, TypeValuePair typeValuePair,
            params Type[] givenTypes)
        {
            var itemType = typeValuePair.Type;
            var expectedType = typeof(TResult);
            var expectedTypePretty = expectedType.PrettyPrint();
            var givenTypesPretty = string.Join(", ", givenTypes.Select(ReflectionUtils.PrettyPrint));

            scope
                .ForCondition(givenTypes.Contains(expectedType))
                .FailWith("Value should be one of {0} but found {1} instead.",
                    givenTypesPretty, expectedTypePretty);

            scope
                .ForCondition(expectedType.IsAssignableFrom(itemType))
                .FailWith("Value should be assignable to {0} but found {1} instead",
                    expectedTypePretty, itemType.PrettyPrint());

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
