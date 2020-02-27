using BenchmarkDotNet.Attributes;
using System;

namespace BlueDove.BenchLab
{
    public class Increment
    {
        [Params(10000)]
        public int count;

        byte[] values;

        byte[] xval;

        [GlobalSetup]
        public void SetUp()
        {
            values = new byte[count];
            xval = new byte[count];
            (new Random()).NextBytes(values);
        }

        [Benchmark]
        public void Post()
        {
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                xval[j++] = values[i];
            }
        }

        [Benchmark]
        public void Pre()
        {
            int j = -1;
            for (int i = 0; i < count; i++)
            {
                xval[++j] = values[i];
            }
        }

        [Benchmark]
        public void For()
        {
            for (int i = 0; i < count; i++)
            {
                xval[i] = values[i];
            }
        }
    }
}
