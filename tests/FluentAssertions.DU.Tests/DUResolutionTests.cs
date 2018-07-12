using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace FluentAssertions.DU.Tests
{
    public class DUResolutionTests
    {
        readonly SwitchableType _testCase = new SwitchableType(
            123, 4.January(2018), TimeSpan.FromMinutes(5), HttpStatusCode.Conflict);

        [Test]
        public void GetFirstDateTimeMethod()
        {
            void Empty<TValue>(TValue value) { }
            var result = _testCase.GetDUResult<DateTime>(Empty);

            result
                .Should().Be(4.January(2018));
        }


        [Test]
        public void GetFirstTimeSpanMethod()
        {
            void Empty<TValue>(TValue value) { }
            var result = _testCase.GetDUResult<TimeSpan>(Empty);

            result
                .Should().Be(TimeSpan.FromMinutes(5));
        }

    }
}
