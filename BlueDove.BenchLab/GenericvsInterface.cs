using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Attributes.
    Jobs;
using System.Runtime.CompilerServices;

namespace BlueDove.BenchLab
{
    [ShortRunJob]
    public class GenericvsInterface
    {
        interface IA
        {
            void N();
        }

        class CA : IA
        {
            public int x;

            public CA(int x)
            {
                this.x = x;
            }

            public void N()
            {
                unchecked
                {
                    x = x ^ (x * x);
                }
            }
        }

        struct SA : IA
        {
            public int x;

            public SA(int x)
            {
                this.x = x;
            }

            public void N()
            {
                unchecked
                {
                    x = x ^ (x * x);
                }
            }
        }

        IA ica;
        IA isa;
        CA ca;
        SA sa;

        void DoAN(IA iA)
        {
            iA.N();
        }

        void DoGenAN<A>(A a) where A : IA
        {
            a.N();
        }

        [GlobalSetup]
        public void Setup()
        {
            var ran = new Random();
            var val = ran.Next();

            ca = new CA(val);
            sa = new SA(val);
            ica = ca;
            isa = sa;
        }

        [Benchmark]
        public void Iica() => DoAN(ica);

        [Benchmark]
        public void Iisa() => DoAN(isa);

        [Benchmark]
        public void Ica() => DoAN(ca);

        [Benchmark]
        public void Isa() => DoAN(sa);

        [Benchmark]
        public void Genica() => DoGenAN(ica);

        [Benchmark]
        public void Genisa() => DoGenAN(isa);

        [Benchmark]
        public void Genca() => DoGenAN(ca);

        [Benchmark]
        public void Gensa() => DoGenAN(sa);

        [Benchmark]
        public void DIca() => ica.N();

        [Benchmark]
        public void DIsa() => isa.N();

        [Benchmark]
        public void DCa() => ca.N();

        [Benchmark]
        public void DSa() => sa.N();
    }
}
