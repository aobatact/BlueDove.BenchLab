using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueDove.BenchLab
{
    public class StructGenericComparerBenchInt
    {
        int x;
        int y;
        int z;

        IComparer<int> sgcd;
        IComparer<int> sgcu;
        IComparer<int> gco;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next();
            y = ran.Next();
            sgcd = new StructGenericComparerDirectory<int>();
            sgcu = new StructGenericComparerUsingCall<int>();
            gco = Comparer<int>.Default;
        }

        [Benchmark]
        public void SGUsingCall()
        {
            z = sgcu.Compare(x, y);
        }

        [Benchmark]
        public void SGDicrectory()
        {
            z = sgcd.Compare(x, y);
        }

        [Benchmark]
        public void GenericCompere()
        {
            z = gco.Compare(x, y);
        }
    }

    internal class StructGenericComparerUsingCall<T> : Comparer<T> where T : struct , IComparable<T>
    {
        public override int Compare(T x, T y) 
            => CallComparerTo(x, y);

        internal int CallComparerTo<TComparable>(TComparable x, TComparable y) where TComparable : IComparable<TComparable> 
            => x.CompareTo(y);

        public override bool Equals(object obj) =>
            obj != null && GetType() == obj.GetType();

        public override int GetHashCode() =>
            GetType().GetHashCode();
    }

    internal class StructGenericComparerDirectory<T> : Comparer<T> where T : struct, IComparable<T>
    {
        public override int Compare(T x, T y)
            => x.CompareTo(y);

        public override bool Equals(object obj) =>
            obj != null && GetType() == obj.GetType();

        public override int GetHashCode() =>
            GetType().GetHashCode();
    }

}
