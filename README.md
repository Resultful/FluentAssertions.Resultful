# FluentAssertions.Resultful

Extension to FluentAssertions which improves the utility of Resultful.
It does this by providing extension methods which fail with useful errors when Result values are found and acted upon.
The installation instructions for this library can be [found here](https://www.nuget.org/packages/FluentAssertions.Resultful/)

# FluentAssertions.OneOf

This project also contains another package.
Extension to FluentAssertions which improves the usage of OneOf to allow easier unit testing.
It does this by providing extensions which fail with useful errors when OneOf like values are found and acted upon.

## Installation

Instructions to install using your appropriate package manager can be [found here](https://www.nuget.org/packages/FluentAssertions.OneOf/)

## Usage

```cs
var testValue = OneOf<int, string, DateTime>.FromT1("Test Value");

testValue.Should().Be<string>()
    .And.Should().Be("Test Value");
```

This asserts the type of the underlying value in the OneOf and returns it is the assertion is successful.
The type passed into the function can be anything, even if it is not present in the given OneOf. This is a limitation of the library that reduces the type safety, but due to the fact that its intended usage is inside of a unit test any failures would be detected quickly. They should also be relatively easy to fix too.
