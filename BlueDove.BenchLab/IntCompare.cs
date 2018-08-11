using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace BlueDove.BenchLab
{
    public class IntCompare
    {
        Func<int, int, int> funccomparer;
        IComparer<int> comparer;

        int x;
        int y;
        public int z;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next();
            y = ran.Next();
            funccomparer = Comparer<int>.Default.Compare;
            comparer = Comparer<int>.Default;
        }

        [Benchmark]
        public void DefaultComparer()
        {
            z = Comparer<int>.Default.Compare(x, y);
        }

        [Benchmark]
        public void Interface()
        {
            z = comparer.Compare(x, y);
        }

        [Benchmark]
        public void Func()
        {
            z = funccomparer(x, y);
        }

        [Benchmark]
        public void CompareTo()
        {
            z = x.CompareTo(y);
        }

        [Benchmark]
        public void GenericComperato()
        {
            z = CompGen(x, y);
        }

        int CompGen<T>(T x,T y) where T : IComparable<T>
        {
            return x.CompareTo(y);
        }
    }




}
