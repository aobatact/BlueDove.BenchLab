using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class FloatShift
    {
        [Params(1000)] public int Count;
        private float[] value;
        private int[] shift;
        private int[] mul;
        private volatile float res;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            value = new float[Count];
            shift = new int[Count];
            mul = new int[Count];
            for (var i = 0; i < Count; i++)
            {
                value[i] = (float) ran.NextDouble();
                var s = shift[i] = ran.Next(10);
                mul[i] = 1 << s;
            }
        }

        [Benchmark]
        public void ShiftA()
        {
            res = 0f;
            for (int i = 0; i < Count; i++)
            {
                res += FloatShifter.ShiftA(value[i], shift[i]);
            }
        }
        
        [Benchmark]
        public void ShiftB()
        {
            res = 0f;
            for (int i = 0; i < Count; i++)
            {
                var val = value[i];
                FloatShifter.ShiftB(ref val, shift[i]);
                res += val;
            }
        }

        [Benchmark]
        public void Mul()
        {
            res = 0f;
            for (int i = 0; i < Count; i++)
            {
                res += value[i] * mul[i];
            }
        }

        static unsafe class FloatShifter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float ShiftA(float value, int shift)
            {
                var x = (int*) &value;
                *x += shift << 23;
                return *(float*) x;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ShiftB(ref float value, int shift)
            {
                ref var x = ref Unsafe.As<float,int>(ref value);
                x += shift << 23;
            }
        }
    }
}