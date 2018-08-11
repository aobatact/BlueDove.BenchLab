using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Attributes.Jobs;

namespace BlueDove.BenchLab
{
    [ShortRunJob]
    public class XorvsEquals
    {
        bool[] x;
        bool[] y;
        bool[] z;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            var xv = ran.Next();
            var yv = ran.Next();
            x = new bool[31];
            y = new bool[31];
            z = new bool[31];
            for (int i = 0; i < 31; i++)
            {
                x[i] = ((xv >> i) & 1) == 1;
                y[i] = ((yv >> i) & 1) == 1;
            }
        }

        [Benchmark]
        public void Xor()
        {
            for (int i = 0; i < 31; i++)
            {
                z[i] = !(x[i] ^ y[i]);
            }
        }

        [Benchmark]
        public void Equals()
        {
            for (int i = 0; i < 31; i++)
            {
                z[i] = x[i].Equals(y[i]);
            }
        }

        [Benchmark]
        public void Equality()
        {
            for (int i = 0; i < 31; i++)
            {
                z[i] = x[i] == y[i];
            }
        }
    }




}
