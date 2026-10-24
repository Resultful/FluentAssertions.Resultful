using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions.Execution;
using FluentAssertions.Union.Models;

namespace FluentAssertions.Union.Utils
{
    public static class AssertionUtils
    {
        internal static void AssertNoMethod<TResult>(AssertionScope scope, Type assertionType, List<UnionMethodInfo> otherPossibilities)
        {
            if (otherPossibilities.Count > 0)
            {
                string Print(UnionMethodInfo info) => info.CaseTypes != null
                    ? string.Join(", ", info.CaseTypes.Select(ReflectionUtils.PrettyPrint))
                    : "";
                var prettyPrintedCases = string.Join(",", otherPossibilities.Select(x => $"{{{Print(x)}}}"));

                scope.FailWith("Multiple Discriminated Union methods found {0}, method types listed {1} non match {2}",
                    assertionType.PrettyPrint(), prettyPrintedCases, typeof(TResult).PrettyPrint());
            }

            scope.FailWith("Unable to find any Discriminated Union method on type {0} for expected type {1}", assertionType.PrettyPrint(), typeof(TResult).PrettyPrint());
        }


        public static TResult Assert<TResult>(this AssertionScope scope, TypeValuePair value)
        {
            var result = value.GetUnionResult<TResult>(items => AssertNoMethod<TResult>(scope, value.Type, items));

            var assertedResult = CheckItemHelper<TResult>(scope, result.TypeValuePair, result.MethodInfo);

            return assertedResult;
        }

        internal static TResult CheckItemHelper<TResult>(AssertionScope scope, TypeValuePair typeValuePair,
            UnionMethodInfo methodInfo)
        { 
            var itemType = typeValuePair.Type;
            var expectedType = typeof(TResult);
            var expectedTypePretty = expectedType.PrettyPrint();

            var givenTypes = (methodInfo.CaseTypes != null && methodInfo.OptionalLast)
                ? methodInfo.CaseTypes.Concat(new[] { typeof(None) }).ToArray()
                : (methodInfo.CaseTypes ?? Array.Empty<Type>());
            var givenTypesPretty = string.Join(", ", givenTypes.Select(ReflectionUtils.PrettyPrint));

            scope
                .ForCondition(givenTypes.Contains(expectedType))
                .FailWith("Value should be one of {0} but found {1} instead.",
                    givenTypesPretty, expectedTypePretty);

            scope
                .ForCondition(expectedType.IsAssignableFrom(itemType))
                .FailWith("Value should be assignable to {0} but found {1} instead",
                    expectedTypePretty, itemType.PrettyPrint());

            return (TResult)typeValuePair.Value!;
        }
    }
}
