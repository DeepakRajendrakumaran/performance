// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

namespace System.Runtime.Intrinsics.Tests
{
    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_Vector128
    {
        private static readonly Vector128<double> _vectorDouble = Vector128.Create(1.0, 2.0);
        private static readonly Vector128<float> _vectorFloat = Vector128.Create(1.0F, 2.0F, 3.0F, 4.0F);
        private static readonly Vector128<long> _vectorLong = Vector128.Create(1, 2);
        private static readonly Vector128<ulong> _vectorULong = Vector128.Create((ulong)1, 2);
        private static readonly Vector128<int> _vectorInt = Vector128.Create(1, 2, 3, 4);
        private static readonly Vector128<uint> _vectorUInt = Vector128.Create((uint)1, 2, 3, 4);
        private static readonly Vector128<short> _vectorShort = Vector128.Create(1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector128<ushort> _vectorUShort = Vector128.Create((ushort)1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector128<sbyte> _vectorSByte = Vector128.Create((sbyte)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector128<byte> _vectorByte = Vector128.Create((byte)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        
        [Benchmark]
        public double DoubleSumBenchmark128() => Vector128.Sum(_vectorDouble);

        [Benchmark]
        public float FloatSumBenchmark128() => Vector128.Sum(_vectorFloat);

        [Benchmark]
        public int IntSumBenchmark128() => Vector128.Sum(_vectorInt);

        [Benchmark]
        public long LongSumBenchmark128() => Vector128.Sum(_vectorLong);

        [Benchmark]
        public uint UIntSumBenchmark128() => Vector128.Sum(_vectorUInt);
        
        [Benchmark]
        public ulong ULongSumBenchmark128() => Vector128.Sum(_vectorULong);

        [Benchmark]
        public ushort UShortSumBenchmark128() => Vector128.Sum(_vectorUShort);
        
        [Benchmark]
        public short ShortSumBenchmark128() => Vector128.Sum(_vectorShort);

        [Benchmark]
        public sbyte SByteSumBenchmark128() => Vector128.Sum(_vectorSByte);
        
        [Benchmark]
        public byte ByteSumBenchmark128() => Vector128.Sum(_vectorByte);
    }

    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_Vector256
    {
        private static readonly Vector256<double> _vectorDouble = Vector256.Create(1.0, 2.0, 1.0, 2.0);
        private static readonly Vector256<float> _vectorFloat = Vector256.Create(1.0F, 2.0F, 3.0F, 4.0F, 1.0F, 2.0F, 3.0F, 4.0F);
        private static readonly Vector256<long> _vectorLong = Vector256.Create(1, 2, 1, 2);
        private static readonly Vector256<ulong> _vectorULong = Vector256.Create((ulong)1, 2, 1, 2);
        private static readonly Vector256<int> _vectorInt = Vector256.Create(1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector256<uint> _vectorUInt = Vector256.Create((uint)1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector256<short> _vectorShort = Vector256.Create(1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector256<ushort> _vectorUShort = Vector256.Create((ushort)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector256<sbyte> _vectorSByte = Vector256.Create((sbyte)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector256<byte> _vectorByte = Vector256.Create((byte)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        
        [Benchmark]
        public double DoubleSumBenchmark256() => Vector256.Sum(_vectorDouble);

        [Benchmark]
        public float FloatSumBenchmark256() => Vector256.Sum(_vectorFloat);

        [Benchmark]
        public int IntSumBenchmark256() => Vector256.Sum(_vectorInt);

        [Benchmark]
        public long LongSumBenchmark256() => Vector256.Sum(_vectorLong);

        [Benchmark]
        public uint UIntSumBenchmark256() => Vector256.Sum(_vectorUInt);
        
        [Benchmark]
        public ulong ULongSumBenchmark256() => Vector256.Sum(_vectorULong);

        [Benchmark]
        public ushort UShortSumBenchmark256() => Vector256.Sum(_vectorUShort);
        
        [Benchmark]
        public short ShortSumBenchmark256() => Vector256.Sum(_vectorShort);

        [Benchmark]
        public sbyte SByteSumBenchmark256() => Vector256.Sum(_vectorSByte);
        
        [Benchmark]
        public byte ByteSumBenchmark256() => Vector256.Sum(_vectorByte);
    }




    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_Vector512
    {
        private static readonly Vector512<double> _vectorDouble = Vector512.Create(1.0, 2.0, 1.0, 2.0, 1.0, 2.0, 1.0, 2.0);
        private static readonly Vector512<float> _vectorFloat = Vector512.Create(1.0F, 2.0F, 3.0F, 4.0F, 1.0F, 2.0F, 3.0F, 4.0F, 1.0F, 2.0F, 3.0F, 4.0F, 1.0F, 2.0F, 3.0F, 4.0F);
        private static readonly Vector512<long> _vectorLong = Vector512.Create(1, 2, 1, 2, 1, 2, 1, 2);
        private static readonly Vector512<ulong> _vectorULong = Vector512.Create((ulong)1, 2, 1, 2, 1, 2, 1, 2);
        private static readonly Vector512<int> _vectorInt = Vector512.Create(1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector512<uint> _vectorUInt = Vector512.Create((uint)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector512<short> _vectorShort = Vector512.Create(1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector512<ushort> _vectorUShort = Vector512.Create((ushort)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector512<sbyte> _vectorSByte = Vector512.Create((sbyte)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        private static readonly Vector512<byte> _vectorByte = Vector512.Create((byte)1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4);
        
        [Benchmark]
        public double DoubleSumBenchmark512() => Vector512.Sum(_vectorDouble);

        [Benchmark]
        public float FloatSumBenchmark512() => Vector512.Sum(_vectorFloat);

        [Benchmark]
        public int IntSumBenchmark512() => Vector512.Sum(_vectorInt);

        [Benchmark]
        public long LongSumBenchmark512() => Vector512.Sum(_vectorLong);

        [Benchmark]
        public uint UIntSumBenchmark512() => Vector512.Sum(_vectorUInt);
        
        [Benchmark]
        public ulong ULongSumBenchmark512() => Vector512.Sum(_vectorULong);

        [Benchmark]
        public ushort UShortSumBenchmark512() => Vector512.Sum(_vectorUShort);
        
        [Benchmark]
        public short ShortSumBenchmark512() => Vector512.Sum(_vectorShort);

        [Benchmark]
        public sbyte SByteSumBenchmark512() => Vector512.Sum(_vectorSByte);
        
        [Benchmark]
        public byte ByteSumBenchmark512() => Vector512.Sum(_vectorByte);
    }


}