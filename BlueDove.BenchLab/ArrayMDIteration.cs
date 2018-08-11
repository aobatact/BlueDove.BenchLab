using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace BlueDove.BenchLab
{
    public class ArrayMDIteration
    {
        int[,] mdarray;
        int[][] jagarray;
        int[] singlearray;

        [Params(10)]
        public int xlength;
        [Params(10)]
        public int ylength;

        volatile int m;

        [GlobalSetup]
        public void SetUp()
        {
            mdarray = new int[xlength, ylength];
            jagarray = new int[ylength][];
            singlearray = new int[xlength * ylength];
            var ran = new Random();
            for (int y = 0; y < ylength; y++)
            {
                jagarray[y] = new int[xlength];
                for (int x = 0; x < xlength; x++)
                {
                    var val = ran.Next();
                    jagarray[y][x] = val;
                    mdarray[x, y] = val;
                    singlearray[x + y * xlength] = val;
                }
            }
        }

        [Benchmark]
        public void RectangularFor()
        {
            for (int y = 0; y < ylength; y++)
            {
                for (int x = 0; x < xlength; x++)
                {
                    m = mdarray[x, y];
                }
            }
        }

        //[Benchmark]
        public void RectangularForEach()
        {
            foreach (var item in mdarray)
            {
                m = item;
            }
        }

        [Benchmark]
        public void JagYF()
        {
            for (int y = 0; y < ylength; y++)
            {
                var xarr = jagarray[y];
                for (int x = 0; x < xlength; x++)
                {
                    m = xarr[x];
                }
            }
        }

        [Benchmark]
        public void JagXF()
        {
            for (int x = 0; x < xlength; x++)
            {
                for (int y = 0; y < ylength; y++)
                {
                    m = jagarray[y][x];
                }
            }
        }

        [Benchmark]
        public void SingleArray()
        {
            for (int y = 0; y < ylength; y++)
            {
                for (int x = 0; x < xlength; x++)
                {
                    m = singlearray[x + y * xlength];
                }
            }
        }        
    }




}
