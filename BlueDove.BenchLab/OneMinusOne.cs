using BenchmarkDotNet.Attributes;
using System;

namespace BlueDove.BenchLab
{
    public class OneMinusOne
    {
        int i;
        [Params(true, false)]
        public bool b;
        double d;

        double value;
        public double res;

        [GlobalSetup]
        public void SetUp()
        {
            d = i = b ? 1 : -1;
            var ran = new Random();
            value = ran.NextDouble();
        }

        [Benchmark]
        public void Bool() => res = b ? value : -value;

        [Benchmark]
        public void Int() => res = value * i;

        [Benchmark]
        public void Double() => res = value * d;
    }
}
