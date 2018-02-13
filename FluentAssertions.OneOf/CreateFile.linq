<Query Kind="Program" />

void Main()
{
    DumpContents("AssertionExtensions.cs", GetAssertionExtensionsContent());
    DumpContents("OneOfAssertions.cs", GetAssertionContent());
}

public void DumpContents(string path, string content){
    var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), path);
    var finalContent = content.Replace("\t", new string(' ', _spacesPerTab));
    File.WriteAllText(outpath.Dump(), finalContent.Dump());
}

public string RollOverItems(IEnumerable<string> items, int numberOfTabs, int numberOfItemsPerLine){
    var checkItemNewLine = _newLine + GetTabs(numberOfTabs);
    return string.Join(",", items.Select((x, index) => {
			var isFirst = index == 0;
			return (index % numberOfItemsPerLine == 0 && !isFirst ? checkItemNewLine : isFirst ? "" : " ") + x;
		}));
}

public static readonly string _newLine = "\r\n";
public static readonly int _spacesPerTab = 4;
private static string GetTabs(int number) => new string('\t', number);

public string GetAssertionContent()
{
    var sb = new StringBuilder();
    sb.Append(@"using System;
using OneOf;
using static FluentAssertions.OneOf.AssertionHelpers;

namespace FluentAssertions.OneOf
{");
    var resultType = "TResult";
    var resultConstraintType = "TResultConstraint";
    for (var i = 1; i < 33; i++)
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
        public AndConstraint<{resultType}> Be<{resultType}>(
            string because = """", params object[] becauseArgs)
        {{
            {resultType} CheckItem<TItem>(TItem element)
                => CheckItemHelper<TItem, {resultType}>(element, becauseArgs, because,
                    {RollOverItems(genericArgs.Select(x => $"typeof({x})"), 5, 5)});");
        sb.AppendLine($@"
            var result = Subject.Match(
                {RollOverItems(Enumerable.Repeat("CheckItem", i), 4, 4)}
            );
            return new AndConstraint<{resultType}>(result);
        }}");

        sb.Append($@"
        public AndConstraint<{resultConstraintType}> Be<{resultType}, {resultConstraintType}>(
            Func<{resultType}, {resultConstraintType}> assertionFunc,
            string because = """", params object[] becauseArgs)
        {{");
        sb.Append(@"
            if(assertionFunc == null)
            {
                throw new ArgumentNullException(nameof(assertionFunc));
            }");

        sb.Append($@"
            var result = Be<{resultType}>(because, becauseArgs);
            return new AndConstraint<{resultConstraintType}>(assertionFunc(result.And));
        }}");


        sb.AppendLine(@"
    }");
    }

sb.AppendLine(@"
}");
    return sb.ToString();
}

private string BuildExtensionMethod(int numberOfArgs){
    var genericArgs = Enumerable.Range(0, numberOfArgs).Select(e => $"T{e}").ToList();
    var genericArgsString = string.Join(", ", genericArgs);
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

public string GetAssertionExtensionsContent(){
    var sb = new StringBuilder();
    sb.Append(@"using System;
using OneOf;
using FluentAssertions;

namespace FluentAssertions.OneOf
{
    public static class AssertionExtensions
    {");
    for (var i = 1; i < 33; i++)
    {
        sb.Append(BuildExtensionMethod(i));
    }
    sb.AppendLine(@"
    }
}");
    return sb.ToString();
}