using BenchmarkDotNet.Attributes;
using System;

namespace BlueDove.BenchLab
{
    public class Increment
    {
        [Params(100)]
        public int Count;

        private int[] values;
        private int zero = 0;
        private Random _random;
        
        [GlobalSetup]
        public void SetUp()
        {
            values = new int[Count];
            _random = new Random();
        }
        
        [Benchmark]
        public void Before()
        {
            var c = 0;
            while (c < Count)
            {
                values[c++] = _random.Next();
            }
        }
        
        [Benchmark]
        public void After()
        {
            var c = -1;
            while (++c < Count)
            {
                values[c] = _random.Next();
            }
        }        
        
        [Benchmark]
        public void AfterS()
        {
            var c = -1;
            var co = Count - 1;
            while (c < co)
            {
                values[++c] = _random.Next();
            }
        }

        [Benchmark]
        public void ForC()
        {
            for (int i = 0; i < Count; i++)
            {
                values[i] = _random.Next();
            }
        }

        [Benchmark]
        public void For()
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = _random.Next();
            }
        }
    }
}
