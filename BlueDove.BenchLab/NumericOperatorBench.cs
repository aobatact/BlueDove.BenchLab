using BenchmarkDotNet.Attributes;
using System;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace BlueDove.BenchLab
{
    [ShortRunJob]
    public class NumericOperatorBench
    {
        int x;
        int y;
        int res;

        IInNumericOperator<int> inno;
        IInNumericOperator<int> sinno;
        InNumericOperatorS_int sinintno;
        INumericOperator<int> no;
        INumericOperator<int> sno;
        NumericOperator_int intno;
        NumericOperatorS_int sintno;
        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next();
            y = ran.Next();
            sinno = sinintno =  new InNumericOperatorS_int();
            inno = new InNumericOperator_int();
            no = intno = new NumericOperator_int();
            sno = sintno = new NumericOperatorS_int();
        }

        [Benchmark]
        public void InNumericOperatorC()
        {
            res = inno.Add(x, y);
        }

        [Benchmark]
        public void InNumericOperatorS()
        {
            res = sinno.Add(x, y);
        }

        [Benchmark]
        public void NInIntOperator()
        {
            res = sinintno.Add(x, y);
        }

        [Benchmark]
        public void NumericOperatorC()
        {
            res = no.Add(x, y);
        }

        [Benchmark]
        public void NumericOperatorS()
        {
            res = sno.Add(x, y);
        }

        [Benchmark]
        public void IntNumericOperatorC()
        {
            res = intno.Add(x, y);
        }

        [Benchmark]
        public void IntNumericOperatorS()
        {
            res = sintno.Add(x, y);
        }

        [Benchmark]
        public void ScalarAdd()
        {
            res = VectorOperation<int>.ScalarAdd(x, y);
        }

        [Benchmark]
        public void VectorAdd()
        {
            res = VectorOperation<int>.VectorAdd(x, y);
        }

        [Benchmark]
        public void Operator()
        {
            res = x + y;
        }
    }

    public class VectorOperation<T> where T : struct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ScalarAdd(T left, T right)
        {
            if (typeof(T) == typeof(Byte))
            {
                return (T)(object)unchecked((Byte)((Byte)(object)left + (Byte)(object)right));
            }
            else if (typeof(T) == typeof(SByte))
            {
                return (T)(object)unchecked((SByte)((SByte)(object)left + (SByte)(object)right));
            }
            else if (typeof(T) == typeof(UInt16))
            {
                return (T)(object)unchecked((UInt16)((UInt16)(object)left + (UInt16)(object)right));
            }
            else if (typeof(T) == typeof(Int16))
            {
                return (T)(object)unchecked((Int16)((Int16)(object)left + (Int16)(object)right));
            }
            else if (typeof(T) == typeof(UInt32))
            {
                return (T)(object)unchecked(((UInt32)(object)left + (UInt32)(object)right));
            }
            else if (typeof(T) == typeof(Int32))
            {
                return (T)(object)unchecked(((Int32)(object)left + (Int32)(object)right));
            }
            else if (typeof(T) == typeof(UInt64))
            {
                return (T)(object)unchecked(((UInt64)(object)left + (UInt64)(object)right));
            }
            else if (typeof(T) == typeof(Int64))
            {
                return (T)(object)unchecked(((Int64)(object)left + (Int64)(object)right));
            }
            else if (typeof(T) == typeof(Single))
            {
                return (T)(object)unchecked(((Single)(object)left + (Single)(object)right));
            }
            else if (typeof(T) == typeof(Double))
            {
                return (T)(object)unchecked(((Double)(object)left + (Double)(object)right));
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T VectorAdd(T left, T right)
        {
            return (new Vector<T>(left) + new Vector<T>(right))[0];
        }
    }

    public interface IInNumericOperator<T> //: IComparer<T>
    {
        T Add(in T left, in T right);
        T Subtract(in T left, in T right);
        T Multiply(in T left, in T right);
        T Divide(in T left, in T right);
        T UnaryPlus(in T value);
        T UnaryMinus(in T value);
        //T Zero{ get; }
        //T One { get; }
    }

    public abstract class InNumericOperator<T> : IInNumericOperator<T>
    {
        public static InNumericOperator<T> Default { get; } = (InNumericOperator<T>)NumericOperatorHelper.CreateInDefualtOperator(typeof(T));

        public abstract T Add(in T left, in T right);
        public abstract T Divide(in T left, in T right);
        public abstract T Multiply(in T left, in T right);
        public abstract T Subtract(in T left, in T right);
        public abstract T UnaryMinus(in T value);
        public abstract T UnaryPlus(in T value);
    }

    public interface INumericOperator<T> //: IComparer<T>
    {
        T Add(T left, T right);
        T Subtract(T left, T right);
        T Multiply(T left, T right);
        T Divide(T left, T right);
        T UnaryPlus(T value);
        T UnaryMinus(T value);
        //T Zero{ get; }
        //T One { get; }
    }

    public abstract class NumericOperator<T> : INumericOperator<T>
    {
        public static NumericOperator<T> Default { get; } = (NumericOperator<T>)NumericOperatorHelper.CreateDefualtOperator(typeof(T));

        public abstract T Add(T left, T right);
        public abstract T Divide(T left, T right);
        public abstract T Multiply(T left, T right);
        public abstract T Subtract(T left, T right);
        public abstract T UnaryMinus(T value);
        public abstract T UnaryPlus(T value);
    }
}
