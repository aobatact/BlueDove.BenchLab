using BenchmarkDotNet.Attributes;
using System;
using System.Runtime.CompilerServices;

namespace BlueDove.BenchLab
{
    public class BoolVsEnum
    {
        enum Benum :byte
        {
            b0,b1,b2,b3
        }
        enum Ienum : int
        {
            i0,i1,i2,i3
        }

        bool a0;
        bool a1;
        byte v;
        Benum benum;
        Ienum ienum;

        int x;

        void Func(int i)
        {
            unchecked
            {
                x = (x * x) ^ x;
            }
        }


        [GlobalSetup]
        public void SetUp()
        {
            a0 = true;
            a1 = false;
            v = 2;
            benum = Benum.b2;
            ienum = Ienum.i2;
            x = 2;
        }

        [Benchmark]
        public void Bool()
        {
            if (a0)
            {
                if (a1)
                {
                    Func(1);
                }
                else
                {
                    Func(0);
                }
            }
            else
            {
                if (a1)
                {
                    Func(3);
                }
                else
                {
                    Func(2);
                }
            }
        }
        
        [Benchmark]
        public void SmarterBool()
        {
            Func(a0 ? a1 ? 1 : 0 : a1 ? 3 : 2);
        }

        [Benchmark]
        public void Byte()
        {
            switch (v)
            {
                case 0:
                    Func(0);
                    return;
                case 1:
                    Func(1);
                    return;
                case 2:
                    Func(2);
                    return;
                case 3:
                    Func(3);
                    return;
                default:
                    throw new Exception();
            }
        }

        [Benchmark]
        public void ByteAsBool()
        {
            var f1 = (byte) (v >> 1);
            ref var b1 = ref Unsafe.As<byte,bool>(ref f1);
            if (Unsafe.As<byte,bool>(ref v))
            {
                Func(b1 ? 1 : 0);
            }
            else
            {
                Func(b1 ? 3 : 2);
            }
        }
        
        [Benchmark]
        public void IntEnum()
        {
            switch (ienum)
            {
                case Ienum.i0:
                    Func(0);
                    return;
                case Ienum.i1:
                    Func(1);
                    return;
                case Ienum.i2:
                    Func(2);
                    return;
                case Ienum.i3:
                    Func(3);
                    return;
                default:
                    throw new Exception();
            }
        }
        
        [Benchmark]
        public void IntEnumThrower()
        {
            switch (ienum)
            {
                case Ienum.i0:
                    Func(0);
                    return;
                case Ienum.i1:
                    Func(1);
                    return;
                case Ienum.i2:
                    Func(2);
                    return;
                case Ienum.i3:
                    Func(3);
                    return;
                default:
                    Thrower();
                    return;
            }
        }

        [Benchmark]
        public void ByteEnum()
        {
            switch (benum)
            {
                case Benum.b0:
                    Func(0);
                    return;
                case Benum.b1:
                    Func(1);
                    return;
                case Benum.b2:
                    Func(2);
                    return;
                case Benum.b3:
                    Func(3);
                    return;
                default:
                    throw new Exception();
            }
        }

        [Benchmark]
        public void ByteEnumThrower()
        {
            switch (benum)
            {
                case Benum.b0:
                    Func(0);
                    return;
                case Benum.b1:
                    Func(1);
                    return;
                case Benum.b2:
                    Func(2);
                    return;
                case Benum.b3:
                    Func(3);
                    return;
                default:
                    Thrower();
                    return;
            }
        }

        
        private void Thrower()
            => throw new Exception();
        
    }




}
