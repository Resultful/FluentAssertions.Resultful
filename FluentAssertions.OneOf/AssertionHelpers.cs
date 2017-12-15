using System;
using System.Linq;
using System.Reflection;
using FluentAssertions.Execution;

namespace FluentAssertions.OneOf
{
    internal class AssertionHelpers
    {
        internal static TResult CheckItemHelper<TItem, TResult>(TItem element,
            object[] becauseArgs, string because = "", params Type[] expectedTypes)
        {
            var itemType = typeof(TItem);
            var expectedType = typeof(TResult);
            var expectedTypePretty = PrettyPrint(expectedType);
            var expectedTypesString = string.Join(", ", expectedTypes.Select(PrettyPrint));
            Execute.Assertion
                .ForCondition(expectedTypes.Contains(expectedType))
                .BecauseOf(because, becauseArgs)
                .FailWith("Value should be one of {0} but found {1} instead.",
                    expectedTypesString, expectedTypePretty);
            
            Execute.Assertion
                .ForCondition(itemType == expectedType)
                .BecauseOf(because, becauseArgs)
                .FailWith("Value should be type {0} but found {1} instead.",
                    expectedTypePretty, PrettyPrint(itemType));

            return (TResult)(object)element;
        }

        internal static string PrettyPrint(Type type)
        {
            var genericArguements = type.GetGenericArguments();
            if (!genericArguements.Any())
            {
                return type.Name;
            }
            var genericName = type.Name.Substring(0, type.Name.IndexOf("`", StringComparison.Ordinal));
            return $"{genericName}<{string.Join(",", genericArguements.Select(PrettyPrint))}>";
        }
    }
}
