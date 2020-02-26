using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class Mul3
    {
        int x;
        public int y;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next(10000);
        }

        [Benchmark]
        public void Mul()
        {
            y = x * 3;
        }

        [Benchmark]
        public void ShiftAdd()
        {
            y = (x << 1) + x;
        }
    }
}