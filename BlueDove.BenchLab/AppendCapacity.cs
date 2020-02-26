using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class AppendCapacity
    {
        private int value;

        [GlobalSetup]
        public void SetUp()
        {
            value = (new Random()).Next();
        }

        [Benchmark]
        public void EnoughCapacity()
        {
            var sb = new StringBuilder();
            sb.Append(value);
        }
        
        [Benchmark]
        public void NotEnoughCapacity()
        {
            var sb = new StringBuilder(1);
            sb.Append(value);
        }
        [Benchmark]
        public void Enough_EnsureCapacity()
        {
            var sb = new StringBuilder();
            var c = CountDigits((uint)value);
            sb.EnsureCapacity(c);
            sb.Append(value);
        }

        [Benchmark]
        public void NotEnough_EnsureCapacity()
        {
            var sb = new StringBuilder(1);
            var c = CountDigits((uint)value);
            sb.EnsureCapacity(c);
            sb.Append(value);
        }

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CountDigits(uint value)
        {
            int digits = 1;
            if (value >= 100000)
            {
                value = value / 100000;
                digits += 5;
            }
 
            if (value < 10)
            {
                // no-op
            }
            else if (value < 100)
            {
                digits += 1;
            }
            else if (value < 1000)
            {
                digits += 2;
            }
            else if (value < 10000)
            {
                digits += 3;
            }
            else
            {
                Debug.Assert(value < 100000);
                digits += 4;
            }
 
            return digits;
        }
        
    }
}