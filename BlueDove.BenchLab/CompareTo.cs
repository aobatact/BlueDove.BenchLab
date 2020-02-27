using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class CompareTo
    {
        private Random random;

        [GlobalSetup]
        public void SetUp()
        {
            random = new Random();
        }

        [Benchmark]
        public int TwoNext()
        {
            random.Next();
            random.Next();
            return 0;
        }

        [Benchmark]
        public int Diff()
        {
            return random.Next() - random.Next();
        }
        
        [Benchmark]
        public int Compare()
        {
            return random.Next() < random.Next() ? -1 : 1;
        }
    }
}