﻿#nullable enable
using System;
using UnityEngine;

namespace Corby.Option
{
    /// <summary>
    /// Represents a value that may or may not exist.<br/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public struct Option<T> : IDisposable,
        IEquatable<Option<T>>,
        IEquatable<None<T>>,
        IEquatable<Some<T>>
    {
        [SerializeField]
        internal T? Value;

        public static implicit operator Option<T>(None<T> none) => new(none);
        public static implicit operator Option<T>(Some<T> some) => new(some);

        private Option(None<T> none)
        {
            Value = default;
        }

        private Option(Some<T> some)
        {
            Value = some.Value;
        }

        public bool Equals(Option<T> other)
        {
            if (Value == null) return other.Value == null;
            return Value.Equals(other.Value);
        }

        public bool Equals(None<T> other)
        {
            return Value == null;
        }

        public bool Equals(Some<T> other)
        {
            if (Value == null) return false;
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj switch
            {
                Option<T> option => Equals(option),
                None<T> none => Equals(none),
                Some<T> some => Equals(some),
                _ => false
            };
        }

        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 0;
        }

        public override string ToString()
        {
            return Value == null ? $"None<{typeof(T).Name}>" : $"Some<{typeof(T).Name}>({Value})";
        }

        public void Dispose()
        {
            if (Value == null) return;
            
            if (Value is IDisposable v)
            {
                v.Dispose();
            }
        }
    }
}