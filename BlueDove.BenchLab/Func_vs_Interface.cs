using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Running;
using System;

namespace BlueDove.BenchLab
{
    public class Func_vs_Interface
    {
        Ac ac;
        IA iA;
        Action action;

        [GlobalSetup]
        public void SetUp()
        {
            ac = new Ac();
            var ran = new Random();
            ac.x = (uint)ran.Next();
            iA = ac;
            action = ac.A;
        }

        [Benchmark]
        public void Func()
        {
            action();
        }

        [Benchmark]
        public void Interface()
        {
            iA.A();
        }

        interface IA
        {
            void A();
        }

        public class Ac : IA
        {
            public uint x;

            public void A()
            {
                x = (x << 16) | (x >> 16);
            }
        }
    }




}
