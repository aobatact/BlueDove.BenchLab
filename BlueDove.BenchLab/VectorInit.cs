using BenchmarkDotNet.Attributes;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace BlueDove.BenchLab
{
    public class VectorInit
    {
        [StructLayout(LayoutKind.Sequential)]
        struct B16
        {
            public int i0;
            public int i1;
            public int i2;
            public int i3;
        }

        B16 b;
        B16 r;
        Random random;

        [GlobalSetup]
        public void SetUp()
        {
            b = default;
            random = new Random();
        }

        [Benchmark]
        public void UseUnsafeV()
        {
            b = default;
            Unsafe.As<B16, int>(ref b) = random.Next();
            Unsafe.Add(ref Unsafe.As<B16, int>(ref b), 1) = random.Next();
            Unsafe.Add(ref Unsafe.As<B16, int>(ref b), 2) = random.Next();
            Unsafe.Add(ref Unsafe.As<B16, int>(ref b), 3) = random.Next();
        }        
        
        [Benchmark]
        public void UseUnsafe()
        {
            b = default;
            ref var i = ref Unsafe.As<B16, int>(ref b);
            i = random.Next();
            Unsafe.Add(ref i, 1) = random.Next();
            Unsafe.Add(ref i, 2) = random.Next();
            Unsafe.Add(ref i, 3) = random.Next();
        }

        [Benchmark]
        public void UseVector()
        {
            var vec = Vector128.Create(random.Next(), random.Next(), random.Next(), random.Next());
            b = Unsafe.As<Vector128<int>, B16>(ref vec);
        }
    }
}
