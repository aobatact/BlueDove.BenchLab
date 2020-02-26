using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    [MinIterationTime(100000000d)]
    public class ArrayExpand
    {
        private int[] array = Array.Empty<int>();
        
        static void ExpandRef(ref int[] array, int count)
        {
            var x = count << 1;
            var newarray = new int[x < 0 ? int.MaxValue : x];
            array.AsSpan().CopyTo(newarray);
            array = newarray;
        }

        static int[] ExpandRet(int[] array, int count)
        {
            var x = count << 1;
            var newarray = new int[x < 0 ? int.MaxValue : x];
            array.AsSpan().CopyTo(newarray);
            return newarray;
        }

        [IterationSetup]
        public void ItSetUp()
        {
            array = Array.Empty<int>();
        }
        
        [Benchmark]
        public void ExpandRef()
        {
            ExpandRef(ref array,4);
        }

        [Benchmark]
        public void ExpandRet()
        {
            array = ExpandRet(array, 4);
        }
    }
}