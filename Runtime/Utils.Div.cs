using System.Numerics;

namespace Corby.Option
{
    public static partial class Utils
    {
        // BigInteger
        public static BigInteger Div(this Option<BigInteger> option, Option<BigInteger> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, BigInteger other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<long> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, long other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<ulong> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<ulong> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, ulong other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<ulong> other)
        {
            return other is Some<ulong> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<int> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, int other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<uint> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, uint other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<short> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, short other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<ushort> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, ushort other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<byte> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, byte other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<sbyte> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, sbyte other)
        {
            return option is Some<BigInteger> some ? some.Value / other : other;
        }

        public static BigInteger Div(this BigInteger option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<float> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<float> otherSome ? some.Value / (BigInteger)otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, float other)
        {
            return option is Some<BigInteger> some ? some.Value / (BigInteger)other : (BigInteger)other;
        }

        public static BigInteger Div(this BigInteger option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (BigInteger)otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<double> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<double> otherSome ? some.Value / (BigInteger)otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, double other)
        {
            return option is Some<BigInteger> some ? some.Value / (BigInteger)other : (BigInteger)other;
        }

        public static BigInteger Div(this BigInteger option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (BigInteger)otherSome.Value : option;
        }

        public static BigInteger Div(this Option<BigInteger> option, Option<decimal> other)
        {
            return option is Some<BigInteger> some
                ? other is Some<decimal> otherSome ? some.Value / (BigInteger)otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<BigInteger> option, decimal other)
        {
            return option is Some<BigInteger> some ? some.Value / (BigInteger)other : (BigInteger)other;
        }

        public static BigInteger Div(this BigInteger option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (BigInteger)otherSome.Value : option;
        }

        // long

        public static BigInteger Div(this Option<long> option, Option<BigInteger> other)
        {
            return option is Some<long> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<long> option, BigInteger other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static BigInteger Div(this long option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<long> other)
        {
            return option is Some<long> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, long other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<int> other)
        {
            return option is Some<long> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, int other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<uint> other)
        {
            return option is Some<long> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, uint other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<short> other)
        {
            return option is Some<long> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, short other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<ushort> other)
        {
            return option is Some<long> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, ushort other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<byte> other)
        {
            return option is Some<long> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, byte other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<sbyte> other)
        {
            return option is Some<long> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, sbyte other)
        {
            return option is Some<long> some ? some.Value / other : other;
        }

        public static long Div(this long option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<float> other)
        {
            return option is Some<long> some
                ? other is Some<float> otherSome ? some.Value / (long)otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, float other)
        {
            return option is Some<long> some ? some.Value / (long)other : (long)other;
        }

        public static long Div(this long option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (long)otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<double> other)
        {
            return option is Some<long> some
                ? other is Some<double> otherSome ? some.Value / (long)otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, double other)
        {
            return option is Some<long> some ? some.Value / (long)other : (long)other;
        }

        public static long Div(this long option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (long)otherSome.Value : option;
        }

        public static long Div(this Option<long> option, Option<decimal> other)
        {
            return option is Some<long> some
                ? other is Some<decimal> otherSome ? some.Value / (long)otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<long> option, decimal other)
        {
            return option is Some<long> some ? some.Value / (long)other : (long)other;
        }

        public static long Div(this long option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (long)otherSome.Value : option;
        }

        // ulong

        public static BigInteger Div(this Option<ulong> option, Option<BigInteger> other)
        {
            return option is Some<ulong> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<ulong> option, BigInteger other)
        {
            return option is Some<ulong> some ? some.Value / other : other;
        }

        public static BigInteger Div(this ulong option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<ulong> other)
        {
            return option is Some<ulong> some
                ? other is Some<ulong> otherSome ? some.Value / otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, ulong other)
        {
            return option is Some<ulong> some ? some.Value / other : other;
        }

        public static ulong Div(this ulong option, Option<ulong> other)
        {
            return other is Some<ulong> otherSome ? option / otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<uint> other)
        {
            return option is Some<ulong> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, uint other)
        {
            return option is Some<ulong> some ? some.Value / other : other;
        }

        public static ulong Div(this ulong option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<ushort> other)
        {
            return option is Some<ulong> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, ushort other)
        {
            return option is Some<ulong> some ? some.Value / other : other;
        }

        public static ulong Div(this ulong option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<byte> other)
        {
            return option is Some<ulong> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, byte other)
        {
            return option is Some<ulong> some ? some.Value / other : other;
        }

        public static ulong Div(this ulong option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<float> other)
        {
            return option is Some<ulong> some
                ? other is Some<float> otherSome ? some.Value / (ulong)otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, float other)
        {
            return option is Some<ulong> some ? some.Value / (ulong)other : (ulong)other;
        }

        public static ulong Div(this ulong option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (ulong)otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<double> other)
        {
            return option is Some<ulong> some
                ? other is Some<double> otherSome ? some.Value / (ulong)otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, double other)
        {
            return option is Some<ulong> some ? some.Value / (ulong)other : (ulong)other;
        }

        public static ulong Div(this ulong option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (ulong)otherSome.Value : option;
        }

        public static ulong Div(this Option<ulong> option, Option<decimal> other)
        {
            return option is Some<ulong> some
                ? other is Some<decimal> otherSome ? some.Value / (ulong)otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<ulong> option, decimal other)
        {
            return option is Some<ulong> some ? some.Value / (ulong)other : (ulong)other;
        }

        public static ulong Div(this ulong option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (ulong)otherSome.Value : option;
        }

        // int

        public static BigInteger Div(this Option<int> option, Option<BigInteger> other)
        {
            return option is Some<int> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<int> option, BigInteger other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static BigInteger Div(this int option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<int> option, Option<long> other)
        {
            return option is Some<int> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<int> option, long other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static long Div(this int option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<int> other)
        {
            return option is Some<int> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, int other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static int Div(this int option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<int> option, Option<uint> other)
        {
            return option is Some<int> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static long Div(this Option<int> option, uint other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static long Div(this int option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<short> other)
        {
            return option is Some<int> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, short other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static int Div(this int option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<ushort> other)
        {
            return option is Some<int> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, ushort other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static int Div(this int option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<byte> other)
        {
            return option is Some<int> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, byte other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static int Div(this int option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<sbyte> other)
        {
            return option is Some<int> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, sbyte other)
        {
            return option is Some<int> some ? some.Value / other : other;
        }

        public static int Div(this int option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<float> other)
        {
            return option is Some<int> some
                ? other is Some<float> otherSome ? some.Value / (int)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, float other)
        {
            return option is Some<int> some ? some.Value / (int)other : (int)other;
        }

        public static int Div(this int option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (int)otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<double> other)
        {
            return option is Some<int> some
                ? other is Some<double> otherSome ? some.Value / (int)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, double other)
        {
            return option is Some<int> some ? some.Value / (int)other : (int)other;
        }

        public static int Div(this int option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (int)otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<decimal> other)
        {
            return option is Some<int> some
                ? other is Some<decimal> otherSome ? some.Value / (int)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, decimal other)
        {
            return option is Some<int> some ? some.Value / (int)other : (int)other;
        }

        public static int Div(this int option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (int)otherSome.Value : option;
        }

        public static int Div(this Option<int> option, Option<ulong> other)
        {
            return option is Some<int> some
                ? other is Some<ulong> otherSome ? some.Value / (int)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<int> option, ulong other)
        {
            return option is Some<int> some ? some.Value / (int)other : (int)other;
        }

        public static int Div(this int option, Option<ulong> other)
        {
            return other is Some<ulong> otherSome ? option / (int)otherSome.Value : option;
        }

        // uint

        public static BigInteger Div(this Option<uint> option, Option<BigInteger> other)
        {
            return option is Some<uint> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<uint> option, BigInteger other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static BigInteger Div(this uint option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<uint> option, Option<long> other)
        {
            return option is Some<uint> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<uint> option, long other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static long Div(this uint option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<uint> option, Option<int> other)
        {
            return option is Some<uint> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<uint> option, int other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static long Div(this uint option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static uint Div(this Option<uint> option, Option<uint> other)
        {
            return option is Some<uint> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0U;
        }

        public static uint Div(this Option<uint> option, uint other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static uint Div(this uint option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<uint> option, Option<short> other)
        {
            return option is Some<uint> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0U;
        }

        public static long Div(this Option<uint> option, short other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static long Div(this uint option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static uint Div(this Option<uint> option, Option<ushort> other)
        {
            return option is Some<uint> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0U;
        }

        public static uint Div(this Option<uint> option, ushort other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static uint Div(this uint option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static uint Div(this Option<uint> option, Option<byte> other)
        {
            return option is Some<uint> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0U;
        }

        public static uint Div(this Option<uint> option, byte other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static uint Div(this uint option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<uint> option, Option<sbyte> other)
        {
            return option is Some<uint> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0U;
        }

        public static long Div(this Option<uint> option, sbyte other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static long Div(this uint option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static uint Div(this Option<uint> option, Option<float> other)
        {
            return option is Some<uint> some
                ? other is Some<float> otherSome ? some.Value / (uint)otherSome.Value : some.Value
                : 0U;
        }

        public static uint Div(this Option<uint> option, float other)
        {
            return option is Some<uint> some ? some.Value / (uint)other : (uint)other;
        }

        public static uint Div(this uint option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (uint)otherSome.Value : option;
        }

        public static uint Div(this Option<uint> option, Option<double> other)
        {
            return option is Some<uint> some
                ? other is Some<double> otherSome ? some.Value / (uint)otherSome.Value : some.Value
                : 0U;
        }

        public static uint Div(this Option<uint> option, double other)
        {
            return option is Some<uint> some ? some.Value / (uint)other : (uint)other;
        }

        public static uint Div(this uint option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (uint)otherSome.Value : option;
        }

        public static uint Div(this Option<uint> option, Option<decimal> other)
        {
            return option is Some<uint> some
                ? other is Some<decimal> otherSome ? some.Value / (uint)otherSome.Value : some.Value
                : 0U;
        }

        public static uint Div(this Option<uint> option, decimal other)
        {
            return option is Some<uint> some ? some.Value / (uint)other : (uint)other;
        }

        public static uint Div(this uint option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (uint)otherSome.Value : option;
        }

        public static ulong Div(this Option<uint> option, Option<ulong> other)
        {
            return option is Some<uint> some
                ? other is Some<ulong> otherSome ? some.Value / otherSome.Value : some.Value
                : 0LU;
        }

        public static ulong Div(this Option<uint> option, ulong other)
        {
            return option is Some<uint> some ? some.Value / other : other;
        }

        public static ulong Div(this uint option, Option<ulong> other)
        {
            return other is Some<ulong> otherSome ? option / otherSome.Value : option;
        }

        // short

        public static BigInteger Div(this Option<short> option, Option<BigInteger> other)
        {
            return option is Some<short> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<short> option, BigInteger other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static BigInteger Div(this short option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<short> option, Option<long> other)
        {
            return option is Some<short> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<short> option, long other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static long Div(this short option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<int> other)
        {
            return option is Some<short> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, int other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static int Div(this short option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<short> option, Option<uint> other)
        {
            return option is Some<short> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static long Div(this Option<short> option, uint other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static long Div(this short option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<short> other)
        {
            return option is Some<short> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, short other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static int Div(this short option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<ushort> other)
        {
            return option is Some<short> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, ushort other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static int Div(this short option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<byte> other)
        {
            return option is Some<short> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, byte other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static int Div(this short option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<sbyte> other)
        {
            return option is Some<short> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, sbyte other)
        {
            return option is Some<short> some ? some.Value / other : other;
        }

        public static int Div(this short option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<float> other)
        {
            return option is Some<short> some
                ? other is Some<float> otherSome ? some.Value / (short)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, float other)
        {
            return option is Some<short> some ? some.Value / (short)other : (short)other;
        }

        public static int Div(this short option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (short)otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<double> other)
        {
            return option is Some<short> some
                ? other is Some<double> otherSome ? some.Value / (short)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, double other)
        {
            return option is Some<short> some ? some.Value / (short)other : (short)other;
        }

        public static int Div(this short option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (short)otherSome.Value : option;
        }

        public static int Div(this Option<short> option, Option<decimal> other)
        {
            return option is Some<short> some
                ? other is Some<decimal> otherSome ? some.Value / (short)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<short> option, decimal other)
        {
            return option is Some<short> some ? some.Value / (short)other : (short)other;
        }

        public static int Div(this short option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (short)otherSome.Value : option;
        }

        // ushort

        public static BigInteger Div(this Option<ushort> option, Option<BigInteger> other)
        {
            return option is Some<ushort> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<ushort> option, BigInteger other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static BigInteger Div(this ushort option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<ushort> option, Option<long> other)
        {
            return option is Some<ushort> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<ushort> option, long other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static long Div(this ushort option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<ushort> option, Option<int> other)
        {
            return option is Some<ushort> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<ushort> option, int other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static long Div(this ushort option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<ushort> option, Option<uint> other)
        {
            return option is Some<ushort> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<ushort> option, uint other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static long Div(this ushort option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<short> other)
        {
            return option is Some<ushort> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, short other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static int Div(this ushort option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<ushort> other)
        {
            return option is Some<ushort> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, ushort other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static int Div(this ushort option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<byte> other)
        {
            return option is Some<ushort> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, byte other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static int Div(this ushort option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<sbyte> other)
        {
            return option is Some<ushort> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, sbyte other)
        {
            return option is Some<ushort> some ? some.Value / other : other;
        }

        public static int Div(this ushort option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<float> other)
        {
            return option is Some<ushort> some
                ? other is Some<float> otherSome ? some.Value / (ushort)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, float other)
        {
            return option is Some<ushort> some ? some.Value / (ushort)other : (ushort)other;
        }

        public static int Div(this ushort option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (ushort)otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<double> other)
        {
            return option is Some<ushort> some
                ? other is Some<double> otherSome ? some.Value / (ushort)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, double other)
        {
            return option is Some<ushort> some ? some.Value / (ushort)other : (ushort)other;
        }

        public static int Div(this ushort option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (ushort)otherSome.Value : option;
        }

        public static int Div(this Option<ushort> option, Option<decimal> other)
        {
            return option is Some<ushort> some
                ? other is Some<decimal> otherSome ? some.Value / (ushort)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<ushort> option, decimal other)
        {
            return option is Some<ushort> some ? some.Value / (ushort)other : (ushort)other;
        }

        public static int Div(this ushort option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (ushort)otherSome.Value : option;
        }

        // byte

        public static BigInteger Div(this Option<byte> option, Option<BigInteger> other)
        {
            return option is Some<byte> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<byte> option, BigInteger other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static BigInteger Div(this byte option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<byte> option, Option<long> other)
        {
            return option is Some<byte> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<byte> option, long other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static long Div(this byte option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<byte> option, Option<int> other)
        {
            return option is Some<byte> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<byte> option, int other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static long Div(this byte option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<byte> option, Option<uint> other)
        {
            return option is Some<byte> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<byte> option, uint other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static long Div(this byte option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<short> other)
        {
            return option is Some<byte> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, short other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static int Div(this byte option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<ushort> other)
        {
            return option is Some<byte> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, ushort other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static int Div(this byte option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<byte> other)
        {
            return option is Some<byte> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, byte other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static int Div(this byte option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<sbyte> other)
        {
            return option is Some<byte> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, sbyte other)
        {
            return option is Some<byte> some ? some.Value / other : other;
        }

        public static int Div(this byte option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<float> other)
        {
            return option is Some<byte> some
                ? other is Some<float> otherSome ? some.Value / (byte)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, float other)
        {
            return option is Some<byte> some ? some.Value / (byte)other : (byte)other;
        }

        public static int Div(this byte option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (byte)otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<double> other)
        {
            return option is Some<byte> some
                ? other is Some<double> otherSome ? some.Value / (byte)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, double other)
        {
            return option is Some<byte> some ? some.Value / (byte)other : (byte)other;
        }

        public static int Div(this byte option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (byte)otherSome.Value : option;
        }

        public static int Div(this Option<byte> option, Option<decimal> other)
        {
            return option is Some<byte> some
                ? other is Some<decimal> otherSome ? some.Value / (byte)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<byte> option, decimal other)
        {
            return option is Some<byte> some ? some.Value / (byte)other : (byte)other;
        }

        public static int Div(this byte option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (byte)otherSome.Value : option;
        }

        // sbyte

        public static BigInteger Div(this Option<sbyte> option, Option<BigInteger> other)
        {
            return option is Some<sbyte> some
                ? other is Some<BigInteger> otherSome ? some.Value / otherSome.Value : some.Value
                : BigInteger.Zero;
        }

        public static BigInteger Div(this Option<sbyte> option, BigInteger other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static BigInteger Div(this sbyte option, Option<BigInteger> other)
        {
            return other is Some<BigInteger> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<sbyte> option, Option<long> other)
        {
            return option is Some<sbyte> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<sbyte> option, long other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static long Div(this sbyte option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<sbyte> option, Option<int> other)
        {
            return option is Some<sbyte> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<sbyte> option, int other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static long Div(this sbyte option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static long Div(this Option<sbyte> option, Option<uint> other)
        {
            return option is Some<sbyte> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0L;
        }

        public static long Div(this Option<sbyte> option, uint other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static long Div(this sbyte option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<short> other)
        {
            return option is Some<sbyte> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, short other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static int Div(this sbyte option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<ushort> other)
        {
            return option is Some<sbyte> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, ushort other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static int Div(this sbyte option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<byte> other)
        {
            return option is Some<sbyte> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, byte other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static int Div(this sbyte option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<sbyte> other)
        {
            return option is Some<sbyte> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, sbyte other)
        {
            return option is Some<sbyte> some ? some.Value / other : other;
        }

        public static int Div(this sbyte option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<float> other)
        {
            return option is Some<sbyte> some
                ? other is Some<float> otherSome ? some.Value / (sbyte)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, float other)
        {
            return option is Some<sbyte> some ? some.Value / (sbyte)other : (sbyte)other;
        }

        public static int Div(this sbyte option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / (sbyte)otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<double> other)
        {
            return option is Some<sbyte> some
                ? other is Some<double> otherSome ? some.Value / (sbyte)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, double other)
        {
            return option is Some<sbyte> some ? some.Value / (sbyte)other : (sbyte)other;
        }

        public static int Div(this sbyte option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / (sbyte)otherSome.Value : option;
        }

        public static int Div(this Option<sbyte> option, Option<decimal> other)
        {
            return option is Some<sbyte> some
                ? other is Some<decimal> otherSome ? some.Value / (sbyte)otherSome.Value : some.Value
                : 0;
        }

        public static int Div(this Option<sbyte> option, decimal other)
        {
            return option is Some<sbyte> some ? some.Value / (sbyte)other : (sbyte)other;
        }

        public static int Div(this sbyte option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / (sbyte)otherSome.Value : option;
        }

        // float

        public static float Div(this Option<float> option, Option<long> other)
        {
            return option is Some<float> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }

        public static float Div(this Option<float> option, long other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }

        public static float Div(this float option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<int> other)
        {
            return option is Some<float> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, int other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<uint> other)
        {
            return option is Some<float> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, uint other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<short> other)
        {
            return option is Some<float> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, short other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<ushort> other)
        {
            return option is Some<float> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, ushort other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<byte> other)
        {
            return option is Some<float> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, byte other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<sbyte> other)
        {
            return option is Some<float> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, sbyte other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static float Div(this Option<float> option, Option<float> other)
        {
            return option is Some<float> some
                ? other is Some<float> otherSome ? some.Value / otherSome.Value : some.Value
                : 0f;
        }
        
        public static float Div(this Option<float> option, float other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static float Div(this float option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<float> option, Option<double> other)
        {
            return option is Some<float> some
                ? other is Some<double> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<float> option, double other)
        {
            return option is Some<float> some ? some.Value / other : other;
        }
        
        public static double Div(this float option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / otherSome.Value : option;
        }

        // double

        public static double Div(this Option<double> option, Option<long> other)
        {
            return option is Some<double> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, long other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<int> other)
        {
            return option is Some<double> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, int other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<uint> other)
        {
            return option is Some<double> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, uint other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<short> other)
        {
            return option is Some<double> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, short other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<ushort> other)
        {
            return option is Some<double> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, ushort other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<byte> other)
        {
            return option is Some<double> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, byte other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<sbyte> other)
        {
            return option is Some<double> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, sbyte other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<float> other)
        {
            return option is Some<double> some
                ? other is Some<float> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, float other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<float> other)
        {
            return other is Some<float> otherSome ? option / otherSome.Value : option;
        }

        public static double Div(this Option<double> option, Option<double> other)
        {
            return option is Some<double> some
                ? other is Some<double> otherSome ? some.Value / otherSome.Value : some.Value
                : 0.0;
        }
        
        public static double Div(this Option<double> option, double other)
        {
            return option is Some<double> some ? some.Value / other : other;
        }
        
        public static double Div(this double option, Option<double> other)
        {
            return other is Some<double> otherSome ? option / otherSome.Value : option;
        }

        // decimal

        public static decimal Div(this Option<decimal> option, Option<long> other)
        {
            return option is Some<decimal> some
                ? other is Some<long> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, long other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<long> other)
        {
            return other is Some<long> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<int> other)
        {
            return option is Some<decimal> some
                ? other is Some<int> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, int other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<int> other)
        {
            return other is Some<int> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<uint> other)
        {
            return option is Some<decimal> some
                ? other is Some<uint> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, uint other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<uint> other)
        {
            return other is Some<uint> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<short> other)
        {
            return option is Some<decimal> some
                ? other is Some<short> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, short other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<short> other)
        {
            return other is Some<short> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<ushort> other)
        {
            return option is Some<decimal> some
                ? other is Some<ushort> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, ushort other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<ushort> other)
        {
            return other is Some<ushort> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<byte> other)
        {
            return option is Some<decimal> some
                ? other is Some<byte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, byte other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<byte> other)
        {
            return other is Some<byte> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<sbyte> other)
        {
            return option is Some<decimal> some
                ? other is Some<sbyte> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, sbyte other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<sbyte> other)
        {
            return other is Some<sbyte> otherSome ? option / otherSome.Value : option;
        }

        public static decimal Div(this Option<decimal> option, Option<decimal> other)
        {
            return option is Some<decimal> some
                ? other is Some<decimal> otherSome ? some.Value / otherSome.Value : some.Value
                : 0m;
        }
        
        public static decimal Div(this Option<decimal> option, decimal other)
        {
            return option is Some<decimal> some ? some.Value / other : other;
        }
        
        public static decimal Div(this decimal option, Option<decimal> other)
        {
            return other is Some<decimal> otherSome ? option / otherSome.Value : option;
        }
    }
}