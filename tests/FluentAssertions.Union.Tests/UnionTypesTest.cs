using System;
using System.Linq;
using System.Net;
using FluentAssertions.Extensions;
using FluentAssertions.Union.Utils;
using NUnit.Framework;

namespace FluentAssertions.Union.Tests
{
    public class UnionTypesTest
    {
        readonly SwitchableType _testCase = new SwitchableType(
            123, 4.January(2018), TimeSpan.FromMinutes(5), HttpStatusCode.Conflict);

        [Test]
        public void GetFirstDateTimeMethod()
        {
            var result = _testCase.GetType().GetAppropriateMethod(typeof(DateTime), out var possibilities);

            result
                .Should()
                .BeEquivalentTo(new MethodResultBuilder
                    {
                        CaseTypes = new[]
                        {
                            typeof(DateTime),
                            typeof(string),
                            typeof(long)
                        },
                        IsSwitch = true,
                        Method = typeof(SwitchableType).GetMethods()
                            .FirstOrDefault(x => x.Name == "Switch" && x.GetParameters().Length == 4),
                        OptionalLast = true
                    }.Create());
        }

        [Test]
        public void GetFirstStringMethod()
        {
            var result = _testCase.GetType().GetAppropriateMethod(typeof(string), out var possibilities);

            result
                .Should()
                .BeEquivalentTo(new MethodResultBuilder
                {
                    CaseTypes = new[]
                    {
                        typeof(int),
                        typeof(string)
                    },
                    IsSwitch = false,
                    Method = typeof(SwitchableType).GetMethods()
                        .FirstOrDefault(x => x.Name == "Match" && x.GetParameters().Length == 2),
                    OptionalLast = false
                }.Create());
        }

        [Test]
        public void IsMatchableType()
        {
            var results = _testCase.GetType().GetMatchMethods();

            results
                .Should()
                .BeEquivalentTo(
                    new MethodResultBuilder
                    {
                        CaseTypes = new[]
                        {
                            typeof(string),
                            typeof(int)
                        },
                        IsSwitch = false,
                        Method = typeof(SwitchableType).GetMethods()
                            .FirstOrDefault(x => x.Name == "Match" && x.GetParameters().Length == 2),
                        OptionalLast = false
                    }.Create(),
                    new MethodResultBuilder
                    {
                        CaseTypes = new[]
                        {
                            typeof(string),
                            typeof(TimeSpan)
                        },
                        IsSwitch = false,
                        Method = typeof(SwitchableType).GetMethods()
                            .FirstOrDefault(x => x.Name == "Match" && x.GetParameters().Length == 3),
                        OptionalLast = true
                    }.Create());
        }


        

        [Test]
        public void IsSwitchableType()
        {
            var result = _testCase.GetType().GetSwitchMethods();

            result
                .Should()
                .BeEquivalentTo(
                    new MethodResultBuilder
                    {
                        CaseTypes = new[]
                        {
                            typeof(HttpStatusCode),
                            typeof(Byte)
                        },
                        IsSwitch = true,
                        Method = typeof(SwitchableType).GetMethods()
                            .FirstOrDefault(x => x.Name == "Switch" && x.GetParameters().Length == 2),
                        OptionalLast = false
                    }.Create(),
                    new MethodResultBuilder
                    {
                        CaseTypes = new[]
                        {
                            typeof(DateTime),
                            typeof(string),
                            typeof(long)
                        },
                        IsSwitch = true,
                        Method = typeof(SwitchableType).GetMethods()
                            .FirstOrDefault(x => x.Name == "Switch" && x.GetParameters().Length == 4),
                        OptionalLast = true
                    }.Create());
        }
    }
}
