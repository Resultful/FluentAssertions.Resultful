using System;
using FluentAssertions.Union.Models;
using FluentAssertions.Union.Utils;
using NUnit.Framework;

namespace FluentAssertions.Union.Tests
{
    public class MethodUtilsTests
    {
        [Test]
        public void GetFunc()
        {
            var resultInstance = new TypeValuePair(typeof(int), 12345);
            TypeValuePair Get<T>(T input) => resultInstance;

            var result = MethodUtils.MakeMatchArg(Get, typeof(string));

            var resolvedMethod = result
                .Should()
                .BeOfType<Func<string, TypeValuePair>>()
                .Which;
            var typePairResult = resolvedMethod
                .Invoke("Test");
            typePairResult.Should().BeEquivalentTo(resultInstance);
        }

        [Test]
        public void GetAction()
        {
            bool called = false;
            void Get<T>(T input) => called = true;

            var result = MethodUtils.MakeAction(Get, typeof(string));

            var resolvedMethod = result
                .Should()
                .BeOfType<Action<string>>()
                .Which;
            resolvedMethod
                .Invoke("Test");

            called.Should().BeTrue();
        }
    }
}
