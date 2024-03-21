using System;

namespace Corby.Option
{
    public class UnwrapException : Exception
    {
        public UnwrapException(string optionToString) : base($"Unwrap failed: {optionToString}")
        {
        }
    }
}