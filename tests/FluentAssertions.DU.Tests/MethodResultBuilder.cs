using System;
using System.Reflection;

namespace FluentAssertions.DU.Tests
{
    internal class MethodResultBuilder
    {
        public Type[] CaseTypes { get; set; }
        public MethodInfo Method { get; set; }
        public bool OptionalLast { get; set; }
        public bool IsSwitch { get; set; }

        public DuMethodInfo Create() => new DuMethodInfo(CaseTypes, Method, OptionalLast, IsSwitch);
    }
}
