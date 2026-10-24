using System;
using System.Collections.Generic;
using System.Text;
using Resultful;

namespace FluentAssertions.Resultful
{
    public class ResultAssertions<T, TError>
    {
        public Result<T, TError> Subject { get; }

        public ResultAssertions(Result<T, TError> subject)
        {
            Subject = subject;
        }
    }


    public class ResultAssertions<T>
    {
        public Result<T> Subject { get; }

        public ResultAssertions(Result<T> subject)
        {
            Subject = subject;
        }
    }

    public class VoidResultAssertions<TError>
    {
        public VoidResult<TError> Subject { get; }

        public VoidResultAssertions(VoidResult<TError> subject)
        {
            Subject = subject;
        }
    }

    public class VoidResultAssertions
    {
        public VoidResult Subject { get; }

        public VoidResultAssertions(VoidResult subject)
        {
            Subject = subject;
        }
    }
}
