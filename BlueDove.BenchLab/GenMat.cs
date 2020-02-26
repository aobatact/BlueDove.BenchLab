using System;
using System.Runtime.CompilerServices;

namespace BlueDove.BenchLab
{
    public class GenMat
    {
        /*
        static Matrix4x4<T> Add<T>(Matrix4x4<T> value1, Matrix4x4<T> value2)
        {
            Matrix4x4<T> m;
            if (typeof(T) == typeof(double)) {
                m.M11 = (T)((double)()value1.M11 + (double)value2.M11);
                m.M12 = value1.M12 + value2.M12;
                m.M13 = value1.M13 + value2.M13;
                m.M14 = value1.M14 + value2.M14;
                m.M21 = value1.M21 + value2.M21;
                m.M22 = value1.M22 + value2.M22;
                m.M23 = value1.M23 + value2.M23;
                m.M24 = value1.M24 + value2.M24;
                m.M31 = value1.M31 + value2.M31;
                m.M32 = value1.M32 + value2.M32;
                m.M33 = value1.M33 + value2.M33;
                m.M34 = value1.M34 + value2.M34;
                m.M41 = value1.M41 + value2.M41;
                m.M42 = value1.M42 + value2.M42;
                m.M43 = value1.M43 + value2.M43;
                m.M44 = value1.M44 + value2.M44;
            }
            return m;
        }

        */
    }

    public struct Matrix4x4<T>
    {
        public T M11;

        public T M12;

        public T M13;

        public T M14;

        public T M21;

        public T M22;

        public T M23;

        public T M24;

        public T M31;

        public T M32;

        public T M33;

        public T M34;

        public T M41;

        public T M42;

        public T M43;

        public T M44;



        [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
        private static T ScalarAdd(T left, T right)
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
                return (T)(object)unchecked((UInt32)((UInt32)(object)left + (UInt32)(object)right));
            }
            else if (typeof(T) == typeof(Int32))
            {
                return (T)(object)unchecked((Int32)((Int32)(object)left + (Int32)(object)right));
            }
            else if (typeof(T) == typeof(UInt64))
            {
                return (T)(object)unchecked((UInt64)((UInt64)(object)left + (UInt64)(object)right));
            }
            else if (typeof(T) == typeof(Int64))
            {
                return (T)(object)unchecked((Int64)((Int64)(object)left + (Int64)(object)right));
            }
            else if (typeof(T) == typeof(Single))
            {
                return (T)(object)unchecked((Single)((Single)(object)left + (Single)(object)right));
            }
            else if (typeof(T) == typeof(Double))
            {
                return (T)(object)unchecked((Double)((Double)(object)left + (Double)(object)right));
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }


}
