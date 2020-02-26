using BenchmarkDotNet.Attributes;
using System;
using System.Runtime.CompilerServices;

namespace BlueDove.BenchLab
{
    [MarkdownExporter]
    public class ZeroOne
    {
        int i;
        ulong ifull;
        [Params(true,false)]
        public bool b;
        double d;

        public double value;
        public double res;

        [GlobalSetup]
        public void SetUp()
        {
            d = i = b ? 1 : 0;
            ifull = b ? ulong.MaxValue : 0; 
            var ran = new Random();
            value = ran.NextDouble();
        }

        [Benchmark]
        public void Bool() => res = b ? value : 0d;

        [Benchmark]
        public void Int() => res = value * i;

        [Benchmark]
        public void Double() => res = value * d;
        
        [Benchmark]
        public void IntAnd()
        {
            var dint = Unsafe.As<double, ulong>(ref d);
            dint &= ifull;
            res = Unsafe.As<ulong, double>(ref dint);
        }
    }
}
