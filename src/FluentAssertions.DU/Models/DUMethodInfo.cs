using System;
using System.Reflection;

namespace FluentAssertions.DU
{
    public class DuMethodInfo
    {
        public Type[] CaseTypes { get; }
        public MethodInfo Method { get; }
        public bool OptionalLast { get; }
        public bool IsSwitch { get; }

        internal DuMethodInfo(Type[] caseTypes, MethodInfo method, bool optionalLast, bool isSwitch)
        {
            CaseTypes = caseTypes;
            Method = method;
            OptionalLast = optionalLast;
            IsSwitch = isSwitch;
        }
    }


}
