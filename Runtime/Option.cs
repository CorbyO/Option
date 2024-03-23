using System;
using UnityEngine;

namespace Corby.Option
{
    public interface Option<T> : IEquatable<Option<T>>
    {
    }

    [Serializable]
    public abstract class SerializableOption
    {
        [SerializeField] protected bool IsSome;
    }

    [Serializable]
    public sealed class SerializableOption<T> : SerializableOption
    {
        [SerializeField] private T _value;

        public Option<T> Get()
        {
            return IsSome ? new Some<T>(_value) : new None<T>();
        }
    }
}