using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class TestThrow
    {
        private Random ran;
        private const string InvalidRandom = "Invalid Random";

        [GlobalSetup]
        public void SetUp()
        {
            ran = new Random();
        }

        [Benchmark(Baseline = true)]
        public void BaseLine() { ran.Next(); }
        
        [Benchmark]
        public void UseHelper()
        {
            if (ran.Next() < 0)
            {
                Throw("Invalid Random");
            }
        }        
        
        [Benchmark]
        public void UseThrow()
        {
            if (ran.Next() < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Random");
            }
        }
                
        [Benchmark]
        public void UseHelperConstMessage()
        {
            if (ran.Next() < 0)
            {
                Throw(InvalidRandom);
            }
        }        
        
        [Benchmark]
        public void UseThrowConstMessage()
        {
            if (ran.Next() < 0)
            {
                throw new ArgumentOutOfRangeException(InvalidRandom);
            }
        }
        
        static void Throw(string msg) => throw  new ArgumentOutOfRangeException(msg);
    }
}
