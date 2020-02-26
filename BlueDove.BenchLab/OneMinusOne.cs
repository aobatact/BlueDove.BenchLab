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

        double _value;
        public double res;

        [GlobalSetup]
        public void SetUp()
        {
            d = i = b ? 1 : -1;
            var ran = new Random();
            _value = ran.NextDouble();
        }

        [Benchmark]
        public void Bool() => res = b ? _value : -_value;

        [Benchmark]
        public void Int() => res = _value * i;

        [Benchmark]
        public void Double() => res = _value * d;
    }
}
