using System;
using System.Net;
using OneOf;

namespace FluentAssertions.Union.Tests
{
    public class SwitchableType
    {
        private readonly OneOf<int, string> _input1;
        private readonly OneOf<DateTime, string, long> _input2;
        private readonly OneOf<TimeSpan, string> _input3;
        private readonly OneOf<HttpStatusCode, byte> _input4;

        public SwitchableType(OneOf<int, string> input1, OneOf<DateTime, string, long> input2, OneOf<TimeSpan, string> input3, OneOf<HttpStatusCode, byte> input4)
        {
            _input1 = input1;
            _input2 = input2;
            _input3 = input3;
            _input4 = input4;
        }

        public T Match<T>(Func<int, T> matchFunc, Func<string, T> matchFunc2)
            => _input1.Match(matchFunc, matchFunc2);

        public void Switch(Action<DateTime> matchFunc, Action<string> matchFunc2, Action<long> matchFunc3, Action defaultFunc)
            => _input2.Switch(matchFunc, matchFunc2, matchFunc3);


        public T Match<T>(Func<TimeSpan, T> matchFunc, Func<string, T> matchFunc2, Func<T> defaultFunc)
            => _input3.Match(matchFunc, matchFunc2);

        public void Switch(Action<HttpStatusCode> matchFunc, Action<byte> matchFunc2)
            => _input4.Switch(matchFunc, matchFunc2);
    }

}
