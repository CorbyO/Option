using System;
using System.Collections.Generic;

namespace Corby.Option
{
    public static class Utils
    {
        public static Option<T> Some<T>(this T value)
        {
            
            if (value is null)
            {
                return new None<T>();
            }

            return new Some<T>(value);
        }
        
        public static bool IsAnd<T>(this Option<T> option, T value)
        {
            return option switch
            {
                Some<T> { Value: var v } => v.Equals(value),
                _ => false
            };
        }
        
        public static bool Is<T>(this Option<T> option, SomePredicate<T> value)
        {
            return option switch
            {
                Some<T> { Value: var v } => value(v),
                _ => false
            };
        }

        public static bool IsNone<T>(this Option<T> option)
        {
            return option is None<T>;
        }

        public static bool IsSome<T>(this Option<T> option)
        {
            return option is Some<T>;
        }
        
        public static IEnumerable<T> WithoutNone<T>(this IEnumerable<Option<T>> option)
        {
            foreach (var o in option)
            {
                if (o is Some<T> some)
                {
                    yield return some.Value;
                }
            }
        }
        
        public static T UnwrapOr<T>(this Option<T> option, T value)
        {
            return option is Some<T> some ? some.Value : value;
        }
        
        public static T Unwrap<T>(this Option<T> option)
        {
            return option is Some<T> some ? some.Value : throw new UnwrapException(option.ToString());
        }
    }

    public class UnwrapException : Exception
    {
        public UnwrapException(string optionToString) : base($"Unwrap failed: {optionToString}")
        {
        }
    }
}