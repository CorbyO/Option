using System;
using System.Collections.Generic;

namespace Corby.Option
{
    public readonly struct Some<T> : Option<T>, IDisposable
    {
        public readonly T Value;
        
        internal Some(T value)
        {
            Value = value;
        }
        
        public void Dispose()
        {
            if (Value is IDisposable v)
            {
                v.Dispose();
            }
        }

        public bool Equals(Some<T> other)
        {
            return Value.Equals(other.Value);
        }

        public bool Equals(Option<T> other)
        {
            return other is Some<T> some && Equals(some);
        }

        public override bool Equals(object obj)
        {
            return obj is Some<T> other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return $"Some<{typeof(T).Name}>({Value})";
        }
    }
}