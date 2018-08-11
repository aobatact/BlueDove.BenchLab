using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace BlueDove.BenchLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new Type[] {
                typeof(Func_vs_Interface),
                typeof(IntCompare),
                typeof(BoolVsEnum),
                typeof(ArrayMDIteration),
                typeof(ArrayMDRandom),
                typeof(ArrayLength),
                typeof(ComparerNullorInterface),
                typeof(GenericvsInterface),
                typeof(Constructor),
                typeof(FuncvsVirtual),
                typeof(RemvsAnd),
                typeof(XorvsEquals),
                typeof(StaticDelegate),
                typeof(MatrixOperatorIn),
                typeof(NumericOperatorBench),
                typeof(StructGenericComparerBenchInt),
                typeof(RemvsAnd32),
                typeof(Mul3),
                typeof(ZeroOne),
                typeof(OneMinusOne),
                typeof(Int2Bytes),
                typeof(Ints2Bytes),
                typeof(Increment),
            });
            switcher.Run(new string[] { "22" });
            //Console.ReadLine();
        }

    }

    public class Mul3
    {
        int x;
        public int y;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next(10000);
        }

        [Benchmark]
        public void Mul()
        {
            y = x * 3;
        }

        [Benchmark]
        public void ShiftAdd()
        {
            y = (x << 1) + x;
        }
    }

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
