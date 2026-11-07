using System;
using System.Reflection;

namespace Resultful.AssertionTests.Union
{
    internal class MethodResultBuilder
    {
        public Type[] CaseTypes { get; set; } = Array.Empty<Type>();
        public MethodInfo Method { get; set; } = default!;
        public bool OptionalLast { get; set; }
        public bool IsSwitch { get; set; }

        public UnionMethodInfo Create() => new UnionMethodInfo(CaseTypes, Method, OptionalLast, IsSwitch);
    }
}
