// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using BenchmarkDotNet.Attributes;
using MicroBenchmarks;

namespace System.Runtime.Intrinsics.Tests
{
    [GenericTypeArguments(typeof(byte))]
    [GenericTypeArguments(typeof(double))]
    [GenericTypeArguments(typeof(short))]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(long))]
    [GenericTypeArguments(typeof(sbyte))]
    [GenericTypeArguments(typeof(float))]
    [GenericTypeArguments(typeof(ushort))]
    [GenericTypeArguments(typeof(uint))]
    [GenericTypeArguments(typeof(ulong))]
    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_Vector128Of<T>
        where T : struct
    {
        private static readonly Vector128<T> Value1 = Vector128<T>.AllBitsSet;


        [Benchmark]
        public T SumBenchmark() =>  Vector128.Sum(Value1);

    }

    [GenericTypeArguments(typeof(byte))]
    [GenericTypeArguments(typeof(double))]
    [GenericTypeArguments(typeof(short))]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(long))]
    [GenericTypeArguments(typeof(sbyte))]
    [GenericTypeArguments(typeof(float))]
    [GenericTypeArguments(typeof(ushort))]
    [GenericTypeArguments(typeof(uint))]
    [GenericTypeArguments(typeof(ulong))]
    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_Vector256Of<T>
        where T : struct
    {
        private static readonly Vector256<T> Value1 = Vector256<T>.AllBitsSet;


        [Benchmark]
        public T SumBenchmark() =>  Vector256.Sum(Value1);

    }

    [GenericTypeArguments(typeof(byte))]
    [GenericTypeArguments(typeof(double))]
    [GenericTypeArguments(typeof(short))]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(long))]
    [GenericTypeArguments(typeof(sbyte))]
    [GenericTypeArguments(typeof(float))]
    [GenericTypeArguments(typeof(ushort))]
    [GenericTypeArguments(typeof(uint))]
    [GenericTypeArguments(typeof(ulong))]
    [BenchmarkCategory(Categories.Libraries, Categories.SIMD, Categories.JIT)]
    public class Perf_Vector512Of<T>
        where T : struct
    {
        private static readonly Vector512<T> Value1 = Vector512<T>.AllBitsSet;


        [Benchmark]
        public T SumBenchmark() =>  Vector512.Sum(Value1);

    }
}