using System.Numerics;

namespace Corby.Option
{
    public static partial class Utils
    {
        // To BigInteger
        
        public static Option<BigInteger> ToBigInteger(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }
        
        public static Option<BigInteger> ToBigInteger(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }

        public static Option<BigInteger> ToBigInteger(this Option<short> option)
        {
            return option is Some<short> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }
        
        public static Option<BigInteger> ToBigInteger(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }

        public static Option<BigInteger> ToBigInteger(this Option<int> option)
        {
            return option is Some<int> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }

        public static Option<BigInteger> ToBigInteger(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }
        
        public static Option<BigInteger> ToBigInteger(this Option<long> option)
        {
            return option is Some<long> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }

        public static Option<BigInteger> ToBigInteger(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<BigInteger>(some.Value) : new None<BigInteger>();
        }
        
        // to ulong
        
        public static Option<ulong> ToU64(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<ulong>(some.Value) : new None<ulong>();
        }

        public static Option<ulong> ToU64(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<short> option)
        {
            return option is Some<short> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<ulong>(some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<int> option)
        {
            return option is Some<int> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<ulong>(some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<long> option)
        {
            return option is Some<long> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<float> option)
        {
            return option is Some<float> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<double> option)
        {
            return option is Some<double> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        public static Option<ulong> ToU64(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<ulong>((ulong)some.Value) : new None<ulong>();
        }
        
        // to long
        
        public static Option<long> ToI64(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<long>(some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<long>(some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<short> option)
        {
            return option is Some<short> some ? new Some<long>(some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<long>(some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<int> option)
        {
            return option is Some<int> some ? new Some<long>(some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<long>(some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<long>((long)some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<long>((long)some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<float> option)
        {
            return option is Some<float> some ? new Some<long>((long)some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<double> option)
        {
            return option is Some<double> some ? new Some<long>((long)some.Value) : new None<long>();
        }
        
        public static Option<long> ToI64(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<long>((long)some.Value) : new None<long>();
        }
        
        // to int
        
        public static Option<int> ToI32(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<int>(some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<int>(some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<short> option)
        {
            return option is Some<short> some ? new Some<int>(some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<int>(some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<long> option)
        {
            return option is Some<long> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<float> option)
        {
            return option is Some<float> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<double> option)
        {
            return option is Some<double> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        public static Option<int> ToI32(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<int>((int)some.Value) : new None<int>();
        }
        
        // to uint
        
        public static Option<uint> ToU32(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<uint>(some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<short> option)
        {
            return option is Some<short> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<uint>(some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<int> option)
        {
            return option is Some<int> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<long> option)
        {
            return option is Some<long> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<float> option)
        {
            return option is Some<float> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<double> option)
        {
            return option is Some<double> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        public static Option<uint> ToU32(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<uint>((uint)some.Value) : new None<uint>();
        }
        
        // to short
        
        public static Option<short> ToI16(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<short>(some.Value) : new None<short>();
        }

        public static Option<short> ToI16(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<short>(some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<int> option)
        {
            return option is Some<int> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<long> option)
        {
            return option is Some<long> some ? new Some<short>((short)some.Value) : new None<short>();
        }

        public static Option<short> ToI16(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<float> option)
        {
            return option is Some<float> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<double> option)
        {
            return option is Some<double> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        public static Option<short> ToI16(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<short>((short)some.Value) : new None<short>();
        }
        
        // to ushort
        
        public static Option<ushort> ToU16(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<ushort>(some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<short> option)
        {
            return option is Some<short> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<int> option)
        {
            return option is Some<int> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<long> option)
        {
            return option is Some<long> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }

        public static Option<ushort> ToU16(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<float> option)
        {
            return option is Some<float> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<double> option)
        {
            return option is Some<double> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        public static Option<ushort> ToU16(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<ushort>((ushort)some.Value) : new None<ushort>();
        }
        
        // to byte
        
        public static Option<byte> ToI8(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<short> option)
        {
            return option is Some<short> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<int> option)
        {
            return option is Some<int> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<long> option)
        {
            return option is Some<long> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<float> option)
        {
            return option is Some<float> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<double> option)
        {
            return option is Some<double> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        public static Option<byte> ToI8(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<byte>((byte)some.Value) : new None<byte>();
        }
        
        // to sbyte
        
        public static Option<sbyte> ToU8(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<sbyte>(some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<short> option)
        {
            return option is Some<short> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<int> option)
        {
            return option is Some<int> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<long> option)
        {
            return option is Some<long> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<float> option)
        {
            return option is Some<float> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<double> option)
        {
            return option is Some<double> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        public static Option<sbyte> ToU8(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<sbyte>((sbyte)some.Value) : new None<sbyte>();
        }
        
        // to float
        
        public static Option<float> ToF32(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<float>(some.Value) : new None<float>();
        }

        public static Option<float> ToF32(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<float>(some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<short> option)
        {
            return option is Some<short> some ? new Some<float>(some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<float>(some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<int> option)
        {
            return option is Some<int> some ? new Some<float>(some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<float>(some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<long> option)
        {
            return option is Some<long> some ? new Some<float>(some.Value) : new None<float>();
        }

        public static Option<float> ToF32(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<float>(some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<float>((float)some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<double> option)
        {
            return option is Some<double> some ? new Some<float>((float)some.Value) : new None<float>();
        }
        
        public static Option<float> ToF32(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<float>((float)some.Value) : new None<float>();
        }
        
        // to double
        
        public static Option<double> ToF64(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<double>(some.Value) : new None<double>();
        }

        public static Option<double> ToF64(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<short> option)
        {
            return option is Some<short> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<int> option)
        {
            return option is Some<int> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<long> option)
        {
            return option is Some<long> some ? new Some<double>(some.Value) : new None<double>();
        }

        public static Option<double> ToF64(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<double>((double)some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<float> option)
        {
            return option is Some<float> some ? new Some<double>(some.Value) : new None<double>();
        }
        
        public static Option<double> ToF64(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<double>((double)some.Value) : new None<double>();
        }
        
        // to decimal
        
        public static Option<decimal> ToF128(this Option<byte> option)
        {
            return option is Some<byte> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<sbyte> option)
        {
            return option is Some<sbyte> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }

        public static Option<decimal> ToF128(this Option<short> option)
        {
            return option is Some<short> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<ushort> option)
        {
            return option is Some<ushort> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<int> option)
        {
            return option is Some<int> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }

        public static Option<decimal> ToF128(this Option<uint> option)
        {
            return option is Some<uint> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<long> option)
        {
            return option is Some<long> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<ulong> option)
        {
            return option is Some<ulong> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<BigInteger> option)
        {
            return option is Some<BigInteger> some ? new Some<decimal>((decimal)some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<float> option)
        {
            return option is Some<float> some ? new Some<decimal>((decimal)some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<double> option)
        {
            return option is Some<double> some ? new Some<decimal>((decimal)some.Value) : new None<decimal>();
        }
        
        public static Option<decimal> ToF128(this Option<decimal> option)
        {
            return option is Some<decimal> some ? new Some<decimal>(some.Value) : new None<decimal>();
        }
    }
}