# FluentAssertions.OneOf
Extension to Fluent Assertions that improves OneOf Compatibility.

# Usage


```cs
var testValue = OneOf<int, string, DateTime>.FromT1("Test Value");

testValue.Should().Be<string>()
    .And.Should().Be("Test Value");
```

This asserts the type of the underlying value in the OneOf and returns it is the assertion is successful.
The type passed into the function can be anything, even if it is not present in the given OneOf. This is a limitation of the library that reduces the type safety, but due to the fact that its intended usage is inside of a unit test any failures would be detected quickly. They should also be relatively easy to fix too.

There could be future improvements for the library which hooks into the recursive structural comparison method ShouldBeEquivalentTo and provides correct semantics and assertion failure messages which are currently broken due to the use of Exceptions when trying to access a property which doesn't have a correct value.
