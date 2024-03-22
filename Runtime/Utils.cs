using System;
using System.Collections.Generic;

namespace Corby.Option
{
    public delegate bool SomePredicate<in T>(T target);
    public delegate T SomeFactory<T>(T some);
    
    public static partial class Utils
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
        
        public static IEnumerable<T> WithoutNone<T>(params Option<T>[] option)
        {
            foreach (var o in option)
            {
                if (o is Some<T> some)
                {
                    yield return some.Value;
                }
            }
        }

        /// <summary>
        /// Convert <see cref="Option{T}"/> to <see cref="IEnumerable{T}"/>.<br/>
        /// If a element is null, convert to <see cref="None{T}"/>.
        /// </summary>
        /// <param name="option"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Option<T>> ToOption<T>(this IEnumerable<T> option)
        {
            foreach (var o in option)
            {
                yield return o.Some();
            }
        }

        /// <summary>
        /// Convert <see cref="Option{T}"/> to <see cref="IEnumerable{T}"/>.<br/>
        /// If a element is null, convert to <see cref="None{T}"/>.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="option"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Option<T>> ToOption<T>(this T t, params T[] option)
        {
            yield return t.Some();
            foreach (var o in option)
            {
                yield return o.Some();
            }
        }
        
        /// <summary>
        /// Convert <see cref="Some{T}"/> to <see cref="IEnumerable{T}"/>.<br/>
        /// If a element is null, exclude it.
        /// </summary>
        /// <param name="option"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Option<T>> ToOptionWithoutNull<T>(this IEnumerable<T> option)
        {
            foreach (var o in option)
            {
                if (o is not null)
                {
                    yield return o.Some();
                }
            }
        }

        /// <summary>
        /// Convert <see cref="Some{T}"/> to <see cref="IEnumerable{T}"/>.<br/>
        /// If a element is null, exclude it.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="option"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Option<T>> ToOptionWithoutNull<T>(this T t, params T[] option)
        {
            if (t is not null)
            {
                yield return t.Some();
            }
            
            foreach (var o in option)
            {
                if (o is not null)
                {
                    yield return o.Some();
                }
            }
        }
        
        public static T UnwrapOr<T>(this Option<T> option, T value)
        {
            if (option is Some<T> some)
            {
                return some.Value;
            }
            
            return value ?? throw new UnwrapException(option.ToString());
        }
        
        public static T Unwrap<T>(this Option<T> option)
        {
            return option is Some<T> some ? some.Value : throw new UnwrapException(option.ToString());
        }
        
        public static Option<T> TakeOrNone<T>(this Option<T> option, SomeFactory<T> predicate)
        {
            return option switch
            {
                Some<T> { Value: var v } => predicate(v).Some(),
                _ => new None<T>()
            };
        }
        
        /// <summary>
        /// Combine two <see cref="Option{T}"/> into a single <see cref="Option{T}"/> with <see cref="ValueTuple{T, T}"/>.<br/>
        /// If all option isn't <see cref="Option{T}"/>, return <see cref="None{T}"/><br/>
        /// </summary>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        public static Option<ValueTuple<T1, T2>> Zip<T1, T2>(this Option<T1> option1, Option<T2> option2)
        {
            return option1 switch
            {
                Some<T1> { Value: var v1 } when option2 is Some<T2> { Value: var v2 } => 
                    new ValueTuple<T1, T2>(v1, v2).Some(),
                _ => new None<ValueTuple<T1, T2>>()
            };
        }
        
        /// <summary>
        /// Combine two <see cref="Option{T}"/> into a single <see cref="Option{T}"/> with <see cref="ValueTuple{T, T}"/>.<br/>
        /// If <see cref="option1"/> is <see cref="Option{T}"/>, return <see cref="None{T}"/><br/>
        /// </summary>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        public static Option<ValueTuple<T1, T2>> Zip<T1, T2>(this Option<T1> option1, T2 option2)
        {
            return option1 switch
            {
                Some<T1> { Value: var v1 } => new ValueTuple<T1, T2>(v1, option2).Some(),
                _ => new None<ValueTuple<T1, T2>>()
            };
        }
        
        public static void ThrowIfNone<T>(this Option<T> option)
        {
            if (option is None<T>)
            {
                throw new NoneReferenceException(typeof(T).Name);
            }
        }
        
        public static void ThrowIfNone<T>(this Option<T> option, string message)
        {
            if (option is None<T>)
            {
                throw new NoneReferenceException(typeof(T).Name, message);
            }
        }
    }
}