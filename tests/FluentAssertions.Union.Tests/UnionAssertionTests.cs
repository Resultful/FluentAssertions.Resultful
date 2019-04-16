using System;
using System.Net;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace FluentAssertions.Union.Tests
{
    public class UnionAssertionTests
    {
        readonly SwitchableType _testCase = new SwitchableType(
            123, 4.January(2018), TimeSpan.FromMinutes(5), HttpStatusCode.Conflict);

        [Test]
        public void GetByteWhenItIsHttpStatusCode()
        {
            Action action = () => _testCase.ShouldBeCase<byte>();

            action.Should().Throw<AssertionException>()
                .WithMessage("Value should be assignable to \"Byte\" but found \"HttpStatusCode\" instead");
        }


        [Test]
        public void GetStringWhenItIsAnythingBut()
        {
            Action action = () => _testCase.ShouldBeCase<string>();

            action.Should().Throw<AssertionException>()
                .WithMessage("Value should be assignable to \"String\" but found \"Int32\" instead");
        }

        [Test]
        public void GetHttpStatusCode()
        {
            _testCase
                .ShouldBeCase<HttpStatusCode>()
                .And
                .Should()
                .Be(HttpStatusCode.Conflict);
        }


        [Test]
        public void GetUnkownType()
        {
            Action action = () => _testCase.ShouldBeCase<decimal>();

            action.Should().Throw<AssertionException>()
                .WithMessage("Unable to find any Discriminated Union method on type \"SwitchableType\" for expected type \"Decimal\"");
        }
    }
}
