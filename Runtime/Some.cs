using System;

namespace Corby.Option
{
    /// <summary>
    /// Represents a value that is present.<br/>
    /// Don't use this class directly, use <see cref="Option{T}"/> instead.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public readonly struct Some<T> : IDisposable,
        IEquatable<Some<T>>,
        IEquatable<Option<T>>
    {
        internal readonly T Value;

        internal Some(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            
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
            return other.Value.Equals(Value);
        }

        public bool Equals(Option<T> other)
        { 
            if (other.Value == null) return false;
            return other.Value.Equals(Value);
        }

        public override bool Equals(object obj)
        {
            return obj switch
            {
                Some<T> some => Equals(some),
                Option<T> option => Equals(option),
                _ => false
            };
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