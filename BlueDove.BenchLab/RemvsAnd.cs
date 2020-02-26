using BenchmarkDotNet.Attributes;
using System;

namespace BlueDove.BenchLab
{
    [ShortRunJob]
    public class RemvsAnd
    {
        int v;
        [Params(2,4,8,16)]
        public int bitcount;
        public int h;
        int rem;
        int and;

        [GlobalSetup]
        public void GSetUp()
        {
            var ran = new Random();
            v = ran.Next();
            h = 0;
        }

        [IterationSetup]
        public void SetUp()
        {
            rem = (1 << bitcount);
            and = rem - 1;
        }

        [Benchmark]
        public void Rem()
        {
            h = v % rem; 
        }

        [Benchmark]
        public void And()
        {
            h = v & and;
        }
    }



    public class RemvsAnd32
    {
        int v;
        public const int rem = 32;
        public int h;
        const int and = rem - 1;

        [GlobalSetup]
        public void GSetUp()
        {
            var ran = new Random();
            v = ran.Next();
            h = 0;
        }

        [Benchmark]
        public void Rem()
        {
            h = v % rem;
        }

        [Benchmark]
        public void And()
        {
            h = v & and;
        }
    }

}
