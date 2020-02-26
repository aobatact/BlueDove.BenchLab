using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class CompoundAssignment
    {
        struct double4
        {
            private double f0;
            private double f1;
            private double f2;
            private double f3;

            public double4(double f0, double f1, double f2, double f3)
            {
                this.f0 = f0;
                this.f1 = f1;
                this.f2 = f2;
                this.f3 = f3;
            }

            public static double4 Add(double4 l, double4 r)
            {
                return new double4(l.f0 + r.f0, l.f1 + r.f1, l.f2 + r.f2, l.f3 + r.f3);
            }
            
            public static double4 AddIn(in double4 l,in double4 r)
            {
                return new double4(l.f0 + r.f0, l.f1 + r.f1, l.f2 + r.f2, l.f3 + r.f3);
            }

            public static double4 AddSelf(double4 l, double4 r)
            {
                l.f0 += r.f0;
                l.f1 += r.f1;
                l.f2 += r.f2;
                l.f3 += r.f3;
                return l;
            }
            
            public static double4 AddSelfIn(double4 l,in double4 r)
            {
                l.f0 += r.f0;
                l.f1 += r.f1;
                l.f2 += r.f2;
                l.f3 += r.f3;
                return l;
            }
            
            public static ref double4 AddSelfRef(ref double4 l,in double4 r)
            {
                l.f0 += r.f0;
                l.f1 += r.f1;
                l.f2 += r.f2;
                l.f3 += r.f3;
                return ref l;
            }
        }

        private double4 left;
        private double4 right;

        private static double4 RandomCreate(Random random)
        {
            return new double4(random.NextDouble(),random.NextDouble(),random.NextDouble(),random.NextDouble());
        }

        public void SetUp()
        {
            var random = new Random();
            left = RandomCreate(random);
            right = RandomCreate(random);
        }

        [Benchmark]
        public void Add()
        {
            left = double4.Add(left, right);
        }
        [Benchmark]
        public void AddIn()
        {
            left = double4.AddIn(left, right);
        }
        [Benchmark]
        public void AddSelf()
        {
            left = double4.AddSelf(left, right);
        }
        [Benchmark]
        public void AddSelfIn()
        {
            left = double4.AddSelfIn(left, right);
        }

        [Benchmark]
        public void AddSelfRef()
        {
            double4.AddSelfRef(ref left, right);
        }

    }
}