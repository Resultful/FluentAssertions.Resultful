using System;
using System.Net;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace FluentAssertions.DU.Tests
{
    public class DuAssertionTests
    {
        readonly SwitchableType _testCase = new SwitchableType(
            123, 4.January(2018), TimeSpan.FromMinutes(5), HttpStatusCode.Conflict);

        [Test]
        public void GetByteWhenItIsHttpStatusCode()
        {
            Action action = () =>  _testCase.Should().BeCase<byte>();

            action.Should().Throw<Exception>();
        }


        [Test]
        public void GetStringWhenItIsAnythingBut()
        {
            Action action = () => _testCase.Should().BeCase<string>();

            action.Should().Throw<Exception>();
        }

        [Test]
        public void GetHttpStatusCode()
        {
            _testCase
                .Should()
                .BeCase<HttpStatusCode>()
                .And
                .Should()
                .Be(HttpStatusCode.Conflict);
        }
    }
}
