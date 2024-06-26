﻿using System;
using System.Collections.Generic;

namespace Corby.Option
{
    public delegate bool SomePredicate<in T>(T target);
    public delegate T SomeFactory<T>(T some);
    public delegate TReturn SomeFactory<out TReturn, in TArg>(TArg some);
    
    public static partial class Utils
    {
        public static Option<T> ToOption<T>(this T value)
        {
            if (value is null)
            {
                return new None<T>();
            }

            return new Some<T>(value);
        }
        
        public static Some<T> ToSome<T>(this T value)
            where T : struct
        {
            return new Some<T>(value);
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
                yield return o.ToOption();
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
            yield return t.ToOption();
            foreach (var o in option)
            {
                yield return o.ToOption();
            }
        }

        public static Option<T> CheckedSub<T>(this T value, T target)
        {
            return value.Equals(target) ? value.ToOption() : new None<T>();
        }
        
        /// <summary>
        /// If <see cref="option1"/> and <see cref="option2"/> is <see cref="Some{T}"/>, return <see cref="option2"/>.<br/>
        /// else return <see cref="None{T}"/>.
        /// </summary>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Option<T> And<T>(this Option<T> option1, Option<T> option2)
        {
            return option1 switch
            {
                Some<T> => option2 switch
                {
                    Some<T> => option2,
                    _ => new None<T>()
                },
                _ => new None<T>()
            };
        }
        
        /// <summary>
        /// If <see cref="option1"/> or <see cref="option2"/> is <see cref="Some{T}"/>, return option with <see cref="Some{T}"/>.<br/>
        /// else return <see cref="None{T}"/>.<br/>
        /// If both <see cref="option1"/> and <see cref="option2"/> is <see cref="Some{T}"/>, return <see cref="option1"/>.
        /// </summary>
        /// <param name="option1"></param>
        /// <param name="option2"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Option<T> Or<T>(this Option<T> option1, Option<T> option2)
        {
            return option1.Unwrap() switch
            {
                Some<T> => option1,
                _ => option2
            };
        }
        
        public static bool Is<T>(this Option<T> option, SomePredicate<T> value)
        {
            return option.Unwrap() switch
            {
                Some<T> { Value: var v } => value(v),
                _ => false
            };
        }

        public static bool IsNone<T>(this Option<T> option)
        {
            return option.Unwrap() is None<T>;
        }

        public static bool IsSome<T>(this Option<T> option) 
        {
            return option.Unwrap() is Some<T>;
        }
        
        public static IEnumerable<T> WithoutNone<T>(this IEnumerable<Option<T>> option)
        {
            foreach (var o in option)
            {
                if (o.Unwrap() is Some<T> some)
                {
                    yield return some.Value;
                }
            }
        }
        
        public static IEnumerable<T> WithoutNone<T>(params Option<T>[] option)
        {
            foreach (var o in option)
            {
                if (o.Unwrap() is Some<T> some)
                {
                    yield return some.Value;
                }
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
                    yield return o.ToOption();
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
                yield return t.ToOption();
            }
            
            foreach (var o in option)
            {
                if (o is not null)
                {
                    yield return o.ToOption();
                }
            }
        }
        
        public static T UnwrapOr<T>(this Option<T> option, T value)
        {
            if (option.Unwrap() is Some<T> some)
            {
                return some.Value;
            }
            
            return value ?? throw new UnwrapException(option.ToString());
        }
        
        public static T Unwrap<T>(this Option<T> option)
        {
            return option.Unwrap() is Some<T> some ? some.Value : throw new UnwrapException(option.ToString());
        }
        
        /// <summary>
        /// If <see cref="option"/> is <see cref="Some{T}"/>, return <see cref="Some{T}"/> with <see cref="predicate"/>.<br/>
        /// </summary>
        /// <param name="option"></param>
        /// <param name="predicate"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Option<T> TakeOrNone<T>(this Option<T> option, SomeFactory<T> predicate)
        {
            return option.Unwrap() switch
            {
                Some<T> { Value: var v } => predicate(v).ToOption(),
                _ => new None<T>()
            };
        }
        
        /// <summary>
        /// If <see cref="option"/> is <see cref="Some{T}"/>, return <see cref="Some{T}"/> with <see cref="predicate"/>.<br/>
        /// </summary>
        /// <param name="option"></param>
        /// <param name="predicate"></param>
        /// <typeparam name="TOut"></typeparam>
        /// <typeparam name="TIn"></typeparam>
        /// <returns></returns>
        public static Option<TOut> TakeOrNone<TOut, TIn>(this Option<TIn> option, SomeFactory<TOut, TIn> predicate)
        {
            return option.Unwrap() switch
            {
                Some<TIn> { Value: var v } => predicate(v).ToOption(),
                _ => new None<TOut>()
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
            return option1.Unwrap() switch
            {
                Some<T1> { Value: var v1 } when option2.Unwrap() is Some<T2> { Value: var v2 } => 
                    new ValueTuple<T1, T2>(v1, v2).ToOption(),
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
            return option1.Unwrap() switch
            {
                Some<T1> { Value: var v1 } => new ValueTuple<T1, T2>(v1, option2).ToOption(),
                _ => new None<ValueTuple<T1, T2>>()
            };
        }
        
        /// <summary>
        /// If <see cref="option"/> is <see cref="None{T}"/>, throw <see cref="NoneReferenceException"/>.
        /// </summary>
        /// <param name="option"></param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="NoneReferenceException"></exception>
        public static void ThrowIfNone<T>(this Option<T> option)
        {
            if (option.IsSome)
            {
                throw new NoneReferenceException(typeof(T).Name);
            }
        }
        
        /// <summary>
        /// If <see cref="option"/> is <see cref="None{T}"/>, throw <see cref="NoneReferenceException"/> with <see cref="message"/>.
        /// </summary>
        /// <param name="option"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="NoneReferenceException"></exception>
        public static void ThrowIfNone<T>(this Option<T> option, string message)
        {
            if (option.Unwrap() is None<T>)
            {
                throw new NoneReferenceException(typeof(T).Name, message);
            }
        }
    }
}