# Resultful.AwesomeAssertions

[AwesomeAssertions](https://awesomeassertions.org) extensions for discriminated unions: assert which case a value
holds, fail with a useful message when it holds another, and carry on asserting against the case's value.

| Package | For |
|:--|:--|
| `Resultful.AwesomeAssertions.Union` | Any union type with a `Match`/`Switch` method: `ShouldBeCase<T>()`, `ShouldBeNone()`. The base for the others. |
| `Resultful.AwesomeAssertions.OneOf` | [OneOf](https://github.com/mcintyre321/OneOf) with 1-8 cases: `Should().BeCase<T>()`. |
| `Resultful.AwesomeAssertions.OneOf.Extended` | OneOf.Extended, 9-32 cases. |
| `Resultful.AwesomeAssertions` | [Resultful](https://github.com/Resultful/Resultful) types. |

## Usage

```cs
using Resultful.AwesomeAssertions.OneOf;

var value = OneOf<Some<int>, None>.FromT0(new Some<int> { Value = 3 });

value.Should().BeCase<Some<int>>()
    .And.Should().BeEquivalentTo(new Some<int> { Value = 3 });

value.Should().BeCase<None>();
// Value should be assignable to "None" but found "Some<Int32>" instead
```

For any other union type, `Resultful.AwesomeAssertions.Union` finds the cases through the type's `Match` or `Switch`
method:

```cs
using Resultful.AwesomeAssertions.Union;

Option.Some(3).ShouldBeCase<int>().And.Should().Be(3);
Option.None<int>().ShouldBeNone();
```

## FluentAssertions (legacy)

FluentAssertions needs a commercial licence from version 8. For projects still on FluentAssertions 7.x, the same
code ships under the original package names and namespaces, built against FluentAssertions `[7.2.0, 8.0.0)`:

| AwesomeAssertions | FluentAssertions 7.x |
|:--|:--|
| `Resultful.AwesomeAssertions.Union` | `FluentAssertions.Union` |
| `Resultful.AwesomeAssertions.OneOf` | `FluentAssertions.OneOf` |
| `Resultful.AwesomeAssertions.OneOf.Extended` | `FluentAssertions.OneOf.Extended` |
| `Resultful.AwesomeAssertions` | `FluentAssertions.Resultful` |

Moving across is a package swap plus a namespace change (`using FluentAssertions.OneOf;` →
`using Resultful.AwesomeAssertions.OneOf;`); the API is the same. New features go into both.

## Building

```bash
dotnet test Resultful.AwesomeAssertions.slnx   # both flavors
dotnet run eng/GenerateOneOf.cs                # regenerate the OneOf files
```

`src/` and `tests/` are the AwesomeAssertions flavor. `legacy/` contains only project files that compile the same
sources against FluentAssertions 7.x.
