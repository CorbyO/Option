using System;

namespace Corby.Option
{
    public class NoneReferenceException : Exception
    {
        public NoneReferenceException() : base("None reference")
        {
        }
        
        public NoneReferenceException(string typeName) : base($"None<{typeName}> reference")
        {
        }
        
        public NoneReferenceException(string typeName, string message) : base($"None<{typeName}> reference: {message}")
        {
        }
    }
}