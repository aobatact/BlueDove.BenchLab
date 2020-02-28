using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    [ShortRunJob]
    public class SwapBench
    {
        private int x;
        private int y;

        [GlobalSetup]
        public void SetUp()
        {
            var random = new Random();
            x = random.Next();
            y = random.Next();
        }

        [Benchmark]
        public void TempSwap()
        {
            var t = x;
            x = y;
            y = t;
        }

        [Benchmark]
        public void TupleSwap() { (y, x) = (x, y); }
    }

    [ShortRunJob]
    public class IndexSwapBench
    {
        private int[] array;

        [GlobalSetup]
        public void SetUp()
        {
            var random = new Random();
            array = new[]
            {
                random.Next(),
                random.Next(),
            };
        }

        [Benchmark]
        public void TempSwap()
        {
            var t = array[0];
            array[0] = array[1];
            array[1] = t;
        }

        [Benchmark]
        public void TupleSwap() { (array[0], array[1]) = (array[1], array[0]); }

        [Benchmark]
        public void TupleRefSwap()
        {
            ref var t0 = ref array[0];
            ref var t1 = ref array[1];
            (t1, t0) = (t0, t1);
        }

        //can only used if swap index is neighbor
        [Benchmark]
        public void Rotate()
        {
            ref var l = ref Unsafe.As<int, ulong>(ref array[0]);
            l = BitOperations.RotateLeft(l, 32);
        }
    }
}
