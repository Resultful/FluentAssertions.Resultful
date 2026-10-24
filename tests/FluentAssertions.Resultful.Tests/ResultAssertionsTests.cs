using NUnit.Framework;
using Resultful;

namespace FluentAssertions.Resultful.Tests
{
    [TestFixture]
    public class ResultAssertionsTests
    {
        [Test]
        public void ResultShouldReturnsResultAssertions()
        {
            Result<int, string> result = 42;
            var assertions = result.Should();
            Assert.That(assertions, Is.Not.Null);
            Assert.That(assertions.Subject.Match(_ => true, _ => false), Is.True);
        }
    }
}
