using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace BlueDove.BenchLab
{
    public class ArrayMDRandom
    {

        int[,] mdarray;
        int[][] jagarray;
        int[] singlearray;

        [Params(10)]
        public int xlength;
        [Params(10)]
        public int ylength;
        [Params(100)]
        public int count;

        volatile int m;
        int[] xaccess;
        int[] yaccess;

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
            xaccess = new int[count];
            yaccess = new int[count];
            for (int i = 0; i < count; i++)
            {
                xaccess[i] = ran.Next(xlength);
                yaccess[i] = ran.Next(ylength);
            }

        }

        [Benchmark]
        public void Rectangular()
        {
            for (int i = 0; i < count; i++)
            {
                m = mdarray[xaccess[i], yaccess[i]];
            }
        }

        [Benchmark]
        public void Jag()
        {
            for (int i = 0; i < count; i++)
            {
                m = jagarray[yaccess[i]][xaccess[i]];
            }
        }

        [Benchmark]
        public void Single()
        {
            for (int i = 0; i < count; i++)
            {
                m = singlearray[xaccess[i] + yaccess[i] * xlength];
            }
        }

    }

}
