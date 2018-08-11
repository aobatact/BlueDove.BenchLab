using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using System;

namespace BlueDove.BenchLab
{
    [MarkdownExporter]
    public class ZeroOne
    {
        int i;
        [Params(true,false)]
        public bool b;
        double d;

        public double value;
        public double res;

        [GlobalSetup]
        public void SetUp()
        {
            d = i = b ? 1 : 0;
            var ran = new Random();
            value = ran.NextDouble();
        }

        [Benchmark]
        public void Bool() => res = b ? value : 0d;

        [Benchmark]
        public void Int() => res = value * i;

        [Benchmark]
        public void Double() => res = value * d;
    }
}
