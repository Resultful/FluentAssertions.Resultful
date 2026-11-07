using System;
using System.Reflection;

#if FLUENTASSERTIONS
namespace FluentAssertions.Union.Models
#else
namespace Resultful.AwesomeAssertions.Union.Models
#endif
{
    public class UnionMethodInfo
    {
        public Type[]? CaseTypes { get; }
        public MethodInfo Method { get; }
        public bool OptionalLast { get; }
        public bool IsSwitch { get; }

        internal UnionMethodInfo(Type[]? caseTypes, MethodInfo method, bool optionalLast, bool isSwitch)
        {
            CaseTypes = caseTypes;
            Method = method;
            OptionalLast = optionalLast;
            IsSwitch = isSwitch;
        }
    }
}
