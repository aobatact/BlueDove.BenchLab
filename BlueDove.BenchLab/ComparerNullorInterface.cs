using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BlueDove.BenchLab
{
    public class ComparerNullorInterface
    {
        IComparer<int> comparer;
        IComparer<int> nullablecomarer;
        IComparer<int> custom;
        IComparer<int> interfacestructcomparer;
        IComparer<int> comparerfst;
        NullDefualtComparer<int> structcomparer;
        int[] values;
        int len = 50;
        public volatile int m;
        [GlobalSetup]
        public void SetUp()
        {
            comparer = Comparer<int>.Default;
            nullablecomarer = null;
            custom = new ReverseComparer();
            values = new int[len];
            var ran = new Random();
            for (int i = 0; i < len; i++)
            {
                values[i] = ran.Next();
            }
            structcomparer = new NullDefualtComparer<int>();
            interfacestructcomparer = new NullDefualtComparer<int>();
            comparerfst = structcomparer.Comparer;
        }

        [Benchmark]
        public void IComaparer()
        {
            var val = 0;
            for (int i = 0; i < len-1;)
            {
                val += comparer.Compare(values[i], values[++i]);
            }
            m = val;
        }

        [Benchmark]
        public void NullDefualt()
        {
            var val = 0;
            for (int i = 0; i < len-1;)
            {
                val += NDCompare(values[i], values[++i],nullablecomarer);        
            }
            m = val;
        }

        [Benchmark]
        public void NUllDefualtCustom()
        {
            var val = 0;
            for (int i = 0; i < len - 1;)
            {
                val += NDCompare(values[i], values[++i], custom);
            }
            m = val;
        }

        [Benchmark]
        public void NUllDefualtStruct()
        {
            var val = 0;
            for (int i = 0; i < len - 1;)
            {
                val += structcomparer.Compare(values[i], values[++i]);
            }
            m = val;
        }

        [Benchmark]
        public void InterrfaceNUllDefualtStruct()
        {
            var val = 0;
            for (int i = 0; i < len - 1;)
            {
                val += interfacestructcomparer.Compare(values[i], values[++i]);
            }
            m = val;
        }

        [Benchmark]
        public void InterrfaceNUllDefualtStructfromProperty()
        {
            var val = 0;
            for (int i = 0; i < len - 1;)
            {
                val += comparerfst.Compare(values[i], values[++i]);
            }
            m = val;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int NDCompare<T>(T x,T y,IComparer<T> comparer = null)
        {
            if (comparer == null)
            {
                return Comparer<T>.Default.Compare(x, y);
            }
            else
            {
                return comparer.Compare(x, y);
            }
        }

        class ReverseComparer : IComparer<int>
        {
            public int Compare(int x, int y) => y.CompareTo(x);
        }

        public struct NullDefualtComparer<T> : IComparer<T>
        {
            readonly IComparer<T> comparer;

            public IComparer<T> Comparer => comparer ?? Comparer<T>.Default;

            public NullDefualtComparer(IComparer<T> comparer)
            {
                this.comparer = comparer;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int Compare(T x, T y)
            {
                return comparer == null ? Comparer<T>.Default.Compare(x, y) : comparer.Compare(x, y);
            }
        }
    }




}
