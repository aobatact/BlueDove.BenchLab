using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace BlueDove.BenchLab
{
    public class StaticDelegate
    {
        double value;
        double result;
        Func<double, double> sfunc;
        Func<double, double> lfunc;
        Func<double, double> ifunc;
        Func<double, double> ilfunc;


        static double X(double x) => x;

        double Y(double y) => y;


        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            value = ran.NextDouble();
            result = 0d;
            sfunc = X;
            lfunc = x => X(x);
            ifunc = Y;
            ilfunc = x => Y(x);
        }

        [Benchmark]
        public void Static()
            => Run(sfunc);

        [Benchmark]
        public void Lamda()
            => Run(lfunc);

        [Benchmark]
        public void Instance()
            => Run(ifunc);

        [Benchmark]
        public void InstanceLamda()
            => Run(ilfunc);

        void Run(Func<double,double> func)
        {
            result = func(value);
        }
    }

}
