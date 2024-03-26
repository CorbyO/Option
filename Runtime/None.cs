using System;

namespace Corby.Option
{
    /// <summary>
    /// Represents a value that does not exist.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public readonly struct None<T> : IEquatable<None<T>>,
        IEquatable<Option<T>>
    {

        /// <summary>
        /// Create <see cref="None"/> without new keyword.
        /// </summary>
        public static None<T> New => new();

        public bool Equals(Option<T> other)
        {
            return other.Value == null;
        }

        public bool Equals(None<T> other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj switch
            {
                None<T> none => Equals(none),
                Option<T> option => Equals(option),
                _ => false
            };
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"None<{typeof(T).Name}>";
        }
    }
}