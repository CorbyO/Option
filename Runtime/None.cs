using System;

namespace Corby.Option
{
    [Serializable]
    public readonly struct None<T> : Option<T>
    {
        /// <summary>
        /// Create <see cref="None"/> without new keyword.
        /// </summary>
        public static None<T> New => new();

        public bool Equals(Option<T> other)
        {
            return other is None<T>;
        }

        public override bool Equals(object obj)
        {
            return obj is None<T>;
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