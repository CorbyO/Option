using System;
using UnityEngine;

namespace Corby.Option
{
    [Serializable]
    public sealed class SerializableOption<T>
    {
        [SerializeField] private bool _isSome;
        [SerializeField] private T _value;

        public Option<T> Get()
        {
            return _isSome ? new Some<T>(_value) : new None<T>();
        }
    }
}