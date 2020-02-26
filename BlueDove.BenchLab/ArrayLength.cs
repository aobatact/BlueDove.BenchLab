using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class ArrayLength
    {
        int len;
        int[] array;
        public int m;

        [GlobalSetup]
        public void SetUp()
        {
            len = 298;
            array = new int[298];
        }

        [Benchmark]
        public void Fromarray()
        {
            m = array.Length;
        }

        [Benchmark]
        public void Fromfield()
        {
            m = len;
        }

    }




}
