using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class RefOrTuple
    {
        private int[] array;
        private int count;

        [GlobalSetup]
        public void SetUp()
        {
            array = new int[4];
            count = 0;
        }

        private void Ref(ref int[] ar,ref int l)
        {
            array[l++] = 2;
            if (l < array.Length) l = 0;
        }
        
        private (int[],int) Arg2Tuple(int[] ar,int l)
        {
            array[l++] = 2;
            if (l < array.Length) l = 0;
            return (ar, l);
        }

        private (int[], int) Tuple2Tuple((int[] ar, int l) x)
        {
            x.ar[x.l++] = 2;
            if (x.l < array.Length) x.l = 0;
            return x;
        }

        [Benchmark]
        public void Ref()
        {
            Ref(ref array,ref count);
        }

        [Benchmark]
        public void Arg2Tuple()
        {
            (array,count) = Arg2Tuple(array, count);
        }
        
        [Benchmark]
        public void Tuple2Tuple()
        {
            (array,count) = Tuple2Tuple((array, count));
        }
    }
}