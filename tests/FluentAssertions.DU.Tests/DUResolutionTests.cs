using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace FluentAssertions.DU.Tests
{
    public class DuResolutionTests
    {
        readonly SwitchableType _testCase = new SwitchableType(
            123, 4.January(2018), TimeSpan.FromMinutes(5), HttpStatusCode.Conflict);

        [Test]
        public void GetFirstDateTime()
        {
            var (result, _) = _testCase.Create().GetDUResult<DateTime>(possibilities => {});

            result
                .Value
                .Should()
                .Be(4.January(2018));
        }

        [Test]
        public void GetFirstLongButFindsDateTime()
        {
            var (result, _) = _testCase.Create().GetDUResult<long>(possibilities => { });

            result
                .Value
                .Should()
                .Be(4.January(2018));
        }


        [Test]
        public void GetFirstTimeSpanMethod()
        {
            var (result, _) = _testCase.Create().GetDUResult<TimeSpan>(possibilities => { });

            result
                .Value
                .Should()
                .Be(TimeSpan.FromMinutes(5));
        }


        [Test]
        public void GetFirstHttpStatusCodeMethod()
        {
            var (result, _) = _testCase.Create().GetDUResult<HttpStatusCode>(possibilities => { });

            result
                .Value
                .Should()
                .Be(HttpStatusCode.Conflict);
        }

    }
}
