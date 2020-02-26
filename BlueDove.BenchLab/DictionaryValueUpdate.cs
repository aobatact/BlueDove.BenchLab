using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{

    public class DictionaryCreate
    {
        class MutableTuple<T1,T2>
        {
            public T1 item1;
            public T2 item2;

            public MutableTuple(T1 item1, T2 item2)
            {
                this.item1 = item1;
                this.item2 = item2;
            }

            public void Deconstruct(out T1 item1, out T2 item2)
            {
                item1 = this.item1;
                item2 = this.item2;
            }
        }
        
        private Dictionary<int, ValueTuple<int, int>> usestruct;
        private Dictionary<int, MutableTuple<int, int>> useclass;

        [Params(100)]
        public int length;

        private int[] a;
        private int[] b;
        private int[] c;

        [GlobalSetup]
        public void SetUp()
        {
            a = new int[length];
            b = new int[length];
            c = new int[length];
            var ran = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = ran.Next();
                b[i] = ran.Next();
                c[i] = ran.Next();
            }
        }

        [Benchmark]
        public void Struct()
        {
            usestruct = new Dictionary<int, (int, int)>();
            for (var i = 0; i < a.Length; i++)
            {
                usestruct.Add(a[i],(b[i],c[i]));
            }
        }
        
        [Benchmark]
        public void Class()
        {
            useclass = new Dictionary<int, MutableTuple<int, int>>();
            for (var i = 0; i < a.Length; i++)
            {
                useclass.Add(a[i],new MutableTuple<int, int>(b[i],c[i]));
            }
        }


    }
    
    public class DictionaryValueUpdate
    {
        class MutableTuple<T1,T2>
        {
            public T1 item1;
            public T2 item2;

            public MutableTuple(T1 item1, T2 item2)
            {
                this.item1 = item1;
                this.item2 = item2;
            }

            public void Deconstruct(out T1 item1, out T2 item2)
            {
                item1 = this.item1;
                item2 = this.item2;
            }
        }
        
        private Dictionary<int, ValueTuple<int, int>> usestruct;
        private Dictionary<int, MutableTuple<int, int>> useclass;
        private int val1;
        private int dummy = 0;
        
        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            val1 = ran.Next();
            var val2 = ran.Next();
            var val3 = ran.Next();
            usestruct = new Dictionary<int, (int, int)>();
            useclass = new Dictionary<int, MutableTuple<int, int>>();
            usestruct[val1] = (val2, val3);
            useclass[val1] = new MutableTuple<int, int>(val2,val3);
        }
        
        [Benchmark]
        public void Struct()
        {
            var range = usestruct[val1];
            var x = range.Item1;
            dummy ^= x;
            range.Item1 = x - 1;
            usestruct[val1] = range;
        }

        [Benchmark]
        public void Class()
        {
            var range = useclass[val1];
            var x = range.item1;
            dummy ^= x;
            range.item1 = x - 1;
        }
        
    }
}