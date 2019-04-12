using System;
using System.Reflection;
using FluentAssertions.Union.Models;

namespace FluentAssertions.Union.Tests
{
    internal class MethodResultBuilder
    {
        public Type[] CaseTypes { get; set; }
        public MethodInfo Method { get; set; }
        public bool OptionalLast { get; set; }
        public bool IsSwitch { get; set; }

        public UnionMethodInfo Create() => new UnionMethodInfo(CaseTypes, Method, OptionalLast, IsSwitch);
    }
}
