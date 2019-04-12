using System;
using System.Net;
using FluentAssertions.Extensions;
using FluentAssertions.Union.Models;
using FluentAssertions.Union.Utils;
using NUnit.Framework;

namespace FluentAssertions.Union.Tests
{
    public class UnionResolutionTests
    {
        readonly SwitchableType _testCase = new SwitchableType(
            123, 4.January(2018), TimeSpan.FromMinutes(5), HttpStatusCode.Conflict);

        [Test]
        public void GetFirstDateTime()
        {
            var (result, _) = _testCase.Create().GetUnionResult<DateTime>(possibilities => {});

            result
                .Value
                .Should()
                .Be(4.January(2018));
        }

        [Test]
        public void GetFirstLongButFindsDateTime()
        {
            var (result, _) = _testCase.Create().GetUnionResult<long>(possibilities => { });

            result
                .Value
                .Should()
                .Be(4.January(2018));
        }


        [Test]
        public void GetFirstTimeSpanMethod()
        {
            var (result, _) = _testCase.Create().GetUnionResult<TimeSpan>(possibilities => { });

            result
                .Value
                .Should()
                .Be(TimeSpan.FromMinutes(5));
        }


        [Test]
        public void GetFirstHttpStatusCodeMethod()
        {
            var (result, _) = _testCase.Create().GetUnionResult<HttpStatusCode>(possibilities => { });

            result
                .Value
                .Should()
                .Be(HttpStatusCode.Conflict);
        }

    }
}
