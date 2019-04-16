<Query Kind="Program" />

void Main()
{
    DumpContents("FluentAssertions.OneOf/AssertionExtensions.Should.cs", GetAssertionExtensionsContent(1, 8));
    DumpContents("FluentAssertions.OneOf/OneOfAssertions.cs", GetAssertionContent(1, 8));
    DumpContents("FluentAssertions.OneOf.Extended/AssertionExtensions.Should.cs", GetAssertionExtensionsContent(9, 32));
    DumpContents("FluentAssertions.OneOf.Extended/OneOfAssertions.cs", GetAssertionContent(9, 32));
}

public void DumpContents(string path, string content){
    var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), path);
    var finalContent = content.Replace("\t", new string(' ', _spacesPerTab));
    File.WriteAllText(outpath.Dump(), finalContent.Dump());
}

public static readonly string _newLine = "\r\n";
public static readonly int _spacesPerTab = 4;
private static string GetTabs(int number) => new string('\t', number);

public string RollOverItems(IEnumerable<string> items, int numberOfTabs, int numberOfItemsPerLine){
    var checkItemNewLine = _newLine + GetTabs(numberOfTabs);
    return string.Join(",", items.Select((x, index) => {
            var isFirst = index == 0;
            return (index % numberOfItemsPerLine == 0 && !isFirst ? checkItemNewLine : isFirst ? "" : " ") + x;
        }));
}

private string _resultType = "TResult";

public string GetAssertionContent(int minimumTypes, int maximumTypes)
{
    var sb = new StringBuilder();
    sb.Append(@"using System;
using OneOf;
using FluentAssertions.DU;
using FluentAssertions.Equivalency;
using FluentAssertions.Execution;

namespace FluentAssertions.OneOf
{");
    var resultConstraintType = "TResultConstraint";
    for (var i = minimumTypes; i <= maximumTypes; i++)
    {
        var genericArgs = Enumerable.Range(0, i).Select(e => $"T{e}").ToList();

        sb.AppendLine($@"
    public class OneOfAssertions<{RollOverItems(genericArgs, 2, 10)}>
    {{
        public OneOfAssertions(OneOf<{RollOverItems(genericArgs, 3, 10)}> item)
        {{
            Subject = item;
        }}

        public OneOf<{RollOverItems(genericArgs, 3, 10)}> Subject {{ get; }}");
        sb.AppendLine($@"
        public AndConstraint<{_resultType}> BeCase<{_resultType}>(
            string because = """", params object[] becauseArgs)
        {{
            var value = Subject.Create();

            var scope = Execute.Assertion.BecauseOf(because, becauseArgs);

            return new AndConstraint<{_resultType}>(scope.Assert<{_resultType}>(value));
        }}");

        sb.Append($@"
        public AndConstraint<{resultConstraintType}> BeCase<{_resultType}, {resultConstraintType}>(
            Func<{_resultType}, {resultConstraintType}> assertionFunc,
            string because = """", params object[] becauseArgs)
        {{");
        sb.Append(@"
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }");

        sb.Append($@"
            var result = BeCase<{_resultType}>(because, becauseArgs);
            return new AndConstraint<{resultConstraintType}>(assertionFunc(result.And));
        }}");
//        sb.AppendLine(@"
//        public void BeEquivalentTo<TExpectation>
//            (TExpectation expectation, string because = """",
//            params object[] becauseArgs)
//                => BeEquivalentTo(expectation, config => config, because, becauseArgs);
//
//        public void BeEquivalentTo<TExpectation>(TExpectation expectation,
//            Func<EquivalencyAssertionOptions<TExpectation>, EquivalencyAssertionOptions<TExpectation>> config,
//            string because = """", params object[] becauseArgs)
//                => AssertionHelpers.BeEquivalentTo(Subject, expectation, config, because, becauseArgs);");
        sb.AppendLine(@"
    }");
    }

sb.AppendLine(@"
}");
    return sb.ToString();
}

private List<string> GetGenericArgs(int numberOfArgs)
    => Enumerable.Range(0, numberOfArgs).Select(e => $"T{e}").ToList();
private List<string> GetItems(int numberOfArgs, string item)
    => Enumerable.Range(0, numberOfArgs).Select(x => item).ToList();

private string BuildExtensionMethod(int numberOfArgs){
    var genericArgs = GetGenericArgs(numberOfArgs);
    return $@"
        public static OneOfAssertions
            <{RollOverItems(genericArgs, 3, 10)}>
                Should
                <{RollOverItems(genericArgs, 4, 10)}>
                (this OneOf
                    <{RollOverItems(genericArgs, 5, 10)}>
                    item)
        {{
            return new OneOfAssertions
                <{RollOverItems(genericArgs, 4, 10)}>
                    (item);
        }}";
}

public string GetAssertionExtensionsContent(int minimumTypes, int maximumTypes){
    var sb = new StringBuilder();
    sb.Append(@"using System;
using OneOf;
using FluentAssertions;

namespace FluentAssertions.OneOf
{
    public static partial class AssertionExtensions
    {");
    for (var i = minimumTypes; i <= maximumTypes; i++)
    {
        sb.Append(BuildExtensionMethod(i));
    }
    sb.AppendLine(@"
    }
}");
    return sb.ToString();
}