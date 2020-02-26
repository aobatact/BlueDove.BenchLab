using BenchmarkDotNet.Attributes;
using System;

namespace BlueDove.BenchLab
{
    [ShortRunJob]
    public class FuncvsVirtual
    {
        class A
        {
            protected int x;

            public A(int x)
            {
                this.x = x;
            }

            public virtual void N() => x = (x * x) ^ x;
        }

        class A1 : A
        {
            public A1(int x) : base(x)
            {
            }

            public override void N() => x = (x * x) ^ x;
        }

        class A2 : A
        {
            public A2(int x) : base(x)
            {
            }

            public override void N() => base.N();
        }

        class A3 : A
        {
            public A3(int x) : base(x)
            {
            }
        }

        sealed class A4 : A
        {
            public A4(int x) : base(x)
            {
            }

            public override void N() => x = (x * x) ^ x;
        }

        class B
        {

            Action action;
            public int val;

            public B( int val)
            {
                this.val = val;
            }

            public void SetAction(Action act) => action = act;

            public void N() => action();
        }

        class C
        {
            int x;

            public C(int x)
            {
                this.x = x;
            }

            public void N() => x = (x * x) ^ x;
        }

        struct S
        {
            int x;

            public S(int x)
            {
                this.x = x;
            }

            public void N() => x = (x * x) ^ x;
        }

        A a;
        A a1;
        A a2;
        A a3;
        A a4;
        B b;
        C c;
        S s;

        [GlobalSetup]
        public void Setup()
        {
            var ran = new Random();
            var val = ran.Next();
            a = new A(val);
            a1 = new A1(val);
            a2 = new A2(val);
            a3 = new A3(val);
            a4 = new A4(val);
            b = new B( val);
            b.SetAction(() => b.val = (b.val * b.val) ^ b.val);
            c = new C(val);
            s = new S(val);
        }

        [Benchmark]
        public void VirtualBase() => a.N();

        [Benchmark]
        public void Overrided() => a1.N();

        [Benchmark]
        public void OverrideUsingBase() => a2.N();

        [Benchmark]
        public void NoOverride() => a3.N();

        [Benchmark]
        public void SealedOverrided() => a4.N();

        [Benchmark]
        public void Action() => b.N();

        [Benchmark]
        public void NoVirtual() => c.N();

        [Benchmark]
        public void Struct() => s.N();
    }




}
