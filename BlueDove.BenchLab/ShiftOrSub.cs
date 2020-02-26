using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class ShiftOrSub
    {
        private volatile int x;
        private volatile int y;
        private volatile int z;
        private volatile int w;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next();
            y = ran.Next();
            z = ran.Next();
        }
        
        [Benchmark]
        public void Shift2()
        {
            w = (x << y) >> z;
        }

        [Benchmark]
        public void ShiftSub()
        {
            w = (x << (y - z));
        }
        
        [Benchmark]
        public void ShiftSubAbs()
        {
            if (y > z)
            {
                w = (x << (y - z));
            }
            else
            {
                w = (x >> (z - y));
            }
        }
    }
}