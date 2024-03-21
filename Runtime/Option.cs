using System;

namespace Corby.Option
{
    public delegate bool SomePredicate<in T>(T target);
    
    public interface Option<T> : IEquatable<Option<T>>
    {
    }
}