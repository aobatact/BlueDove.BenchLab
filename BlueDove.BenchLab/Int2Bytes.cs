using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Runtime.InteropServices;

namespace BlueDove.BenchLab
{
    public class Int2Bytes
    {
        int value;
        byte[] bytes;

        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            value = ran.Next();
        }

        [Benchmark]
        public void StructCast() => bytes = new IntBytes(value).ToArray();

        [Benchmark]
        public void Convert() => bytes = BitConverter.GetBytes(value);

        [Benchmark]
        public void Span() => bytes = MemoryMarshal.AsBytes(new Span<int>(new int[] { value })).ToArray();

        [StructLayout(LayoutKind.Explicit)]
        struct IntBytes
        {
            [FieldOffset(0)]
            int ivalue;

            [FieldOffset(0)]
            byte b0;

            [FieldOffset(1)]
            byte b1;

            [FieldOffset(2)]
            byte b2;

            [FieldOffset(3)]
            byte b3;

            public IntBytes(int value) : this()
            {
                ivalue = value;
            }

            public byte this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0:
                            return b0;
                        case 1:
                            return b1;
                        case 2:
                            return b2;
                        case 3:
                            return b3;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public byte[] ToArray()
            {
                var array = new byte[4];
                array[0] = b0;
                array[1] = b1;
                array[2] = b2;
                array[3] = b3;
                return array;
            }
        }

    }

    public class Ints2Bytes
    {
        int[] values;
        byte[] bytes;
        [Params(1, 10)]
        public int length;

        [GlobalSetup]
        public void SetUp()
        {
            values = new int[length];
            var ran = new Random();
            for (int i = 0; i < length; i++)
            {
                values[i] = (ran.Next() << 2) ^ ran.Next();
            }
        }

        [Benchmark]
        public void StructCast()
        {
            bytes = new byte[values.Length * sizeof(int)];
            for (int i = 0, index = 0; i < values.Length; i++, index += sizeof(int))
            {
                new IntBytes(values[i]).CopyTo(bytes, index);
            }
        }

        [Benchmark]
        public void Convert()
        {
            byte[] bs;
            bytes = new byte[values.Length * sizeof(int)];
            for (int i = 0, index = 0; i < values.Length; i++, index += sizeof(int))
            {
                bs = BitConverter.GetBytes(values[i]);
                Buffer.BlockCopy(bs, 0, bytes, index, sizeof(int));
            }
        }

        [Benchmark]
        public void Span() => bytes = MemoryMarshal.AsBytes(new Span<int>(values)).ToArray();

        [Benchmark]
        public void Copy()
        {
            bytes = new byte[values.Length * sizeof(int)];
            Buffer.BlockCopy(values, 0, bytes, 0, bytes.Length);
        }

        [StructLayout(LayoutKind.Explicit)]
        struct IntBytes
        {
            [FieldOffset(0)]
            int ivalue;

            [FieldOffset(0)]
            byte b0;

            [FieldOffset(1)]
            byte b1;

            [FieldOffset(2)]
            byte b2;

            [FieldOffset(3)]
            byte b3;

            public IntBytes(int value) : this()
            {
                ivalue = value;
            }

            public byte this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0:
                            return b0;
                        case 1:
                            return b1;
                        case 2:
                            return b2;
                        case 3:
                            return b3;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            public byte[] ToArray()
            {
                var array = new byte[4];
                array[0] = b0;
                array[1] = b1;
                array[2] = b2;
                array[3] = b3;
                return array;
            }

            public void CopyTo(byte[] bytes, int index)
            {
                bytes[index++] = b0;
                bytes[index++] = b1;
                bytes[index++] = b2;
                bytes[index] = b3;
            }
        }

    }
}
