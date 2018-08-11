using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace BlueDove.BenchLab
{
    public class MatrixOperatorIn
    {
        /*
        public struct OldMatrix4x4
        {
            #region Public Fields
            /// <summary>
            /// Value at row 1, column 1 of the matrix.
            /// </summary>
            public float M11;
            /// <summary>
            /// Value at row 1, column 2 of the matrix.
            /// </summary>
            public float M12;
            /// <summary>
            /// Value at row 1, column 3 of the matrix.
            /// </summary>
            public float M13;
            /// <summary>
            /// Value at row 1, column 4 of the matrix.
            /// </summary>
            public float M14;

            /// <summary>
            /// Value at row 2, column 1 of the matrix.
            /// </summary>
            public float M21;
            /// <summary>
            /// Value at row 2, column 2 of the matrix.
            /// </summary>
            public float M22;
            /// <summary>
            /// Value at row 2, column 3 of the matrix.
            /// </summary>
            public float M23;
            /// <summary>
            /// Value at row 2, column 4 of the matrix.
            /// </summary>
            public float M24;

            /// <summary>
            /// Value at row 3, column 1 of the matrix.
            /// </summary>
            public float M31;
            /// <summary>
            /// Value at row 3, column 2 of the matrix.
            /// </summary>
            public float M32;
            /// <summary>
            /// Value at row 3, column 3 of the matrix.
            /// </summary>
            public float M33;
            /// <summary>
            /// Value at row 3, column 4 of the matrix.
            /// </summary>
            public float M34;

            /// <summary>
            /// Value at row 4, column 1 of the matrix.
            /// </summary>
            public float M41;
            /// <summary>
            /// Value at row 4, column 2 of the matrix.
            /// </summary>
            public float M42;
            /// <summary>
            /// Value at row 4, column 3 of the matrix.
            /// </summary>
            public float M43;
            /// <summary>
            /// Value at row 4, column 4 of the matrix.
            /// </summary>
            public float M44;
            #endregion Public Fields

            public static OldMatrix4x4 operator +(OldMatrix4x4 value1, OldMatrix4x4 value2)
            {
                OldMatrix4x4 m;

                m.M11 = value1.M11 + value2.M11;
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

                return m;
            }

            public static OldMatrix4x4 operator *(OldMatrix4x4 value1, OldMatrix4x4 value2)
            {
                OldMatrix4x4 m;

                // First row
                m.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31 + value1.M14 * value2.M41;
                m.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32 + value1.M14 * value2.M42;
                m.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33 + value1.M14 * value2.M43;
                m.M14 = value1.M11 * value2.M14 + value1.M12 * value2.M24 + value1.M13 * value2.M34 + value1.M14 * value2.M44;

                // Second row
                m.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31 + value1.M24 * value2.M41;
                m.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32 + value1.M24 * value2.M42;
                m.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33 + value1.M24 * value2.M43;
                m.M24 = value1.M21 * value2.M14 + value1.M22 * value2.M24 + value1.M23 * value2.M34 + value1.M24 * value2.M44;

                // Third row
                m.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31 + value1.M34 * value2.M41;
                m.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32 + value1.M34 * value2.M42;
                m.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33 + value1.M34 * value2.M43;
                m.M34 = value1.M31 * value2.M14 + value1.M32 * value2.M24 + value1.M33 * value2.M34 + value1.M34 * value2.M44;

                // Fourth row
                m.M41 = value1.M41 * value2.M11 + value1.M42 * value2.M21 + value1.M43 * value2.M31 + value1.M44 * value2.M41;
                m.M42 = value1.M41 * value2.M12 + value1.M42 * value2.M22 + value1.M43 * value2.M32 + value1.M44 * value2.M42;
                m.M43 = value1.M41 * value2.M13 + value1.M42 * value2.M23 + value1.M43 * value2.M33 + value1.M44 * value2.M43;
                m.M44 = value1.M41 * value2.M14 + value1.M42 * value2.M24 + value1.M43 * value2.M34 + value1.M44 * value2.M44;

                return m;
            }
        }

        public struct NewMatrix4x4
        {
            #region Public Fields
            /// <summary>
            /// Value at row 1, column 1 of the matrix.
            /// </summary>
            public float M11;
            /// <summary>
            /// Value at row 1, column 2 of the matrix.
            /// </summary>
            public float M12;
            /// <summary>
            /// Value at row 1, column 3 of the matrix.
            /// </summary>
            public float M13;
            /// <summary>
            /// Value at row 1, column 4 of the matrix.
            /// </summary>
            public float M14;

            /// <summary>
            /// Value at row 2, column 1 of the matrix.
            /// </summary>
            public float M21;
            /// <summary>
            /// Value at row 2, column 2 of the matrix.
            /// </summary>
            public float M22;
            /// <summary>
            /// Value at row 2, column 3 of the matrix.
            /// </summary>
            public float M23;
            /// <summary>
            /// Value at row 2, column 4 of the matrix.
            /// </summary>
            public float M24;

            /// <summary>
            /// Value at row 3, column 1 of the matrix.
            /// </summary>
            public float M31;
            /// <summary>
            /// Value at row 3, column 2 of the matrix.
            /// </summary>
            public float M32;
            /// <summary>
            /// Value at row 3, column 3 of the matrix.
            /// </summary>
            public float M33;
            /// <summary>
            /// Value at row 3, column 4 of the matrix.
            /// </summary>
            public float M34;

            /// <summary>
            /// Value at row 4, column 1 of the matrix.
            /// </summary>
            public float M41;
            /// <summary>
            /// Value at row 4, column 2 of the matrix.
            /// </summary>
            public float M42;
            /// <summary>
            /// Value at row 4, column 3 of the matrix.
            /// </summary>
            public float M43;
            /// <summary>
            /// Value at row 4, column 4 of the matrix.
            /// </summary>
            public float M44;
            #endregion Public Fields

            public static NewMatrix4x4 operator +(in NewMatrix4x4 value1,in NewMatrix4x4 value2)
            {
                NewMatrix4x4 m;

                m.M11 = value1.M11 + value2.M11;
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

                return m;
            }

            public static NewMatrix4x4 operator *(in NewMatrix4x4 value1,in NewMatrix4x4 value2)
            {
                NewMatrix4x4 m;

                // First row
                m.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31 + value1.M14 * value2.M41;
                m.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32 + value1.M14 * value2.M42;
                m.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33 + value1.M14 * value2.M43;
                m.M14 = value1.M11 * value2.M14 + value1.M12 * value2.M24 + value1.M13 * value2.M34 + value1.M14 * value2.M44;

                // Second row
                m.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31 + value1.M24 * value2.M41;
                m.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32 + value1.M24 * value2.M42;
                m.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33 + value1.M24 * value2.M43;
                m.M24 = value1.M21 * value2.M14 + value1.M22 * value2.M24 + value1.M23 * value2.M34 + value1.M24 * value2.M44;

                // Third row
                m.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31 + value1.M34 * value2.M41;
                m.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32 + value1.M34 * value2.M42;
                m.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33 + value1.M34 * value2.M43;
                m.M34 = value1.M31 * value2.M14 + value1.M32 * value2.M24 + value1.M33 * value2.M34 + value1.M34 * value2.M44;

                // Fourth row
                m.M41 = value1.M41 * value2.M11 + value1.M42 * value2.M21 + value1.M43 * value2.M31 + value1.M44 * value2.M41;
                m.M42 = value1.M41 * value2.M12 + value1.M42 * value2.M22 + value1.M43 * value2.M32 + value1.M44 * value2.M42;
                m.M43 = value1.M41 * value2.M13 + value1.M42 * value2.M23 + value1.M43 * value2.M33 + value1.M44 * value2.M43;
                m.M44 = value1.M41 * value2.M14 + value1.M42 * value2.M24 + value1.M43 * value2.M34 + value1.M44 * value2.M44;

                return m;
            }
        }

        private (OldMatrix4x4 oldmatrix,NewMatrix4x4 newmatrix) CreateRandom()
        {
            var random = new Random();
            var oldm = new OldMatrix4x4();
            var newm = new NewMatrix4x4();
            newm.M11 = oldm.M11 = (float)random.NextDouble();
            newm.M12 = oldm.M12 = (float)random.NextDouble();
            newm.M13 = oldm.M13 = (float)random.NextDouble();
            newm.M14 = oldm.M14 = (float)random.NextDouble();
            newm.M21 = oldm.M21 = (float)random.NextDouble();
            newm.M22 = oldm.M22 = (float)random.NextDouble();
            newm.M23 = oldm.M23 = (float)random.NextDouble();
            newm.M24 = oldm.M24 = (float)random.NextDouble();
            newm.M31 = oldm.M31 = (float)random.NextDouble();
            newm.M32 = oldm.M32 = (float)random.NextDouble();
            newm.M33 = oldm.M33 = (float)random.NextDouble();
            newm.M34 = oldm.M34 = (float)random.NextDouble();
            newm.M41 = oldm.M41 = (float)random.NextDouble();
            newm.M42 = oldm.M42 = (float)random.NextDouble();
            newm.M43 = oldm.M43 = (float)random.NextDouble();
            newm.M44 = oldm.M44 = (float)random.NextDouble();
            return (oldm, newm);
        }

        OldMatrix4x4 oldMatrix1;
        NewMatrix4x4 newMatrix1;
        OldMatrix4x4 oldMatrix2;
        NewMatrix4x4 newMatrix2;
        OldMatrix4x4 oldresult;
        NewMatrix4x4 newresult;

        [GlobalSetup]
        public void SetUp()
        {
            (oldMatrix1, newMatrix1) = CreateRandom();
            (oldMatrix2, newMatrix2) = CreateRandom();
        }

        [Benchmark]
        public void WithoutInAdd()
        {
            oldresult = oldMatrix1 + oldMatrix2;
        }

        [Benchmark]
        public void WithoutInMul()
        {
            oldresult = oldMatrix1 * oldMatrix2;
        }

        [Benchmark]
        public void WithInAdd()
        {
            newresult = newMatrix1 + newMatrix2;
        }

        [Benchmark]
        public void WithInMul()
        {
            newresult = newMatrix1 *  newMatrix2;
        }
        */
        static Matrix4x4 OldAdd(Matrix4x4 value1, Matrix4x4 value2)
        {
            Matrix4x4 m;

            m.M11 = value1.M11 + value2.M11;
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

            return m;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Matrix4x4 Add(Matrix4x4 value1, Matrix4x4 value2)
        {
            return AddIn(in value1, in value2);
            /*
            Matrix4x4 m;

            m.M11 = value1.M11 + value2.M11;
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

            return m;*/
        }

        private static Matrix4x4 AddIn(in Matrix4x4 value1,in Matrix4x4 value2)
        {
            Matrix4x4 m;

            m.M11 = value1.M11 + value2.M11;
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

            return m;
        }

        static Matrix4x4 Multiply(Matrix4x4 value1, Matrix4x4 value2)
        {
            Matrix4x4 m;

            // First row
            m.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31 + value1.M14 * value2.M41;
            m.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32 + value1.M14 * value2.M42;
            m.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33 + value1.M14 * value2.M43;
            m.M14 = value1.M11 * value2.M14 + value1.M12 * value2.M24 + value1.M13 * value2.M34 + value1.M14 * value2.M44;

            // Second row
            m.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31 + value1.M24 * value2.M41;
            m.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32 + value1.M24 * value2.M42;
            m.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33 + value1.M24 * value2.M43;
            m.M24 = value1.M21 * value2.M14 + value1.M22 * value2.M24 + value1.M23 * value2.M34 + value1.M24 * value2.M44;

            // Third row
            m.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31 + value1.M34 * value2.M41;
            m.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32 + value1.M34 * value2.M42;
            m.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33 + value1.M34 * value2.M43;
            m.M34 = value1.M31 * value2.M14 + value1.M32 * value2.M24 + value1.M33 * value2.M34 + value1.M34 * value2.M44;

            // Fourth row
            m.M41 = value1.M41 * value2.M11 + value1.M42 * value2.M21 + value1.M43 * value2.M31 + value1.M44 * value2.M41;
            m.M42 = value1.M41 * value2.M12 + value1.M42 * value2.M22 + value1.M43 * value2.M32 + value1.M44 * value2.M42;
            m.M43 = value1.M41 * value2.M13 + value1.M42 * value2.M23 + value1.M43 * value2.M33 + value1.M44 * value2.M43;
            m.M44 = value1.M41 * value2.M14 + value1.M42 * value2.M24 + value1.M43 * value2.M34 + value1.M44 * value2.M44;

            return m;
        }

        static Matrix4x4 InMultiply(in Matrix4x4 value1, in Matrix4x4 value2)
        {
            Matrix4x4 m;

            // First row
            m.M11 = value1.M11 * value2.M11 + value1.M12 * value2.M21 + value1.M13 * value2.M31 + value1.M14 * value2.M41;
            m.M12 = value1.M11 * value2.M12 + value1.M12 * value2.M22 + value1.M13 * value2.M32 + value1.M14 * value2.M42;
            m.M13 = value1.M11 * value2.M13 + value1.M12 * value2.M23 + value1.M13 * value2.M33 + value1.M14 * value2.M43;
            m.M14 = value1.M11 * value2.M14 + value1.M12 * value2.M24 + value1.M13 * value2.M34 + value1.M14 * value2.M44;

            // Second row
            m.M21 = value1.M21 * value2.M11 + value1.M22 * value2.M21 + value1.M23 * value2.M31 + value1.M24 * value2.M41;
            m.M22 = value1.M21 * value2.M12 + value1.M22 * value2.M22 + value1.M23 * value2.M32 + value1.M24 * value2.M42;
            m.M23 = value1.M21 * value2.M13 + value1.M22 * value2.M23 + value1.M23 * value2.M33 + value1.M24 * value2.M43;
            m.M24 = value1.M21 * value2.M14 + value1.M22 * value2.M24 + value1.M23 * value2.M34 + value1.M24 * value2.M44;

            // Third row
            m.M31 = value1.M31 * value2.M11 + value1.M32 * value2.M21 + value1.M33 * value2.M31 + value1.M34 * value2.M41;
            m.M32 = value1.M31 * value2.M12 + value1.M32 * value2.M22 + value1.M33 * value2.M32 + value1.M34 * value2.M42;
            m.M33 = value1.M31 * value2.M13 + value1.M32 * value2.M23 + value1.M33 * value2.M33 + value1.M34 * value2.M43;
            m.M34 = value1.M31 * value2.M14 + value1.M32 * value2.M24 + value1.M33 * value2.M34 + value1.M34 * value2.M44;

            // Fourth row
            m.M41 = value1.M41 * value2.M11 + value1.M42 * value2.M21 + value1.M43 * value2.M31 + value1.M44 * value2.M41;
            m.M42 = value1.M41 * value2.M12 + value1.M42 * value2.M22 + value1.M43 * value2.M32 + value1.M44 * value2.M42;
            m.M43 = value1.M41 * value2.M13 + value1.M42 * value2.M23 + value1.M43 * value2.M33 + value1.M44 * value2.M43;
            m.M44 = value1.M41 * value2.M14 + value1.M42 * value2.M24 + value1.M43 * value2.M34 + value1.M44 * value2.M44;

            return m;
        }

        Matrix4x4 matrix_1;
        Matrix4x4 matrix_2;
        Matrix4x4 result;
        Matrix4x4 CreateRandom()
        {
            var random = new Random();
            var matrix = new Matrix4x4();
            matrix.M11 = (float)random.NextDouble();
            matrix.M12 = (float)random.NextDouble();
            matrix.M13 = (float)random.NextDouble();
            matrix.M14 = (float)random.NextDouble();
            matrix.M21 = (float)random.NextDouble();
            matrix.M22 = (float)random.NextDouble();
            matrix.M23 = (float)random.NextDouble();
            matrix.M24 = (float)random.NextDouble();
            matrix.M31 = (float)random.NextDouble();
            matrix.M32 = (float)random.NextDouble();
            matrix.M33 = (float)random.NextDouble();
            matrix.M34 = (float)random.NextDouble();
            matrix.M41 = (float)random.NextDouble();
            matrix.M42 = (float)random.NextDouble();
            matrix.M43 = (float)random.NextDouble();
            matrix.M44 = (float)random.NextDouble();
            return matrix;
        }

        [GlobalSetup]
        public void SetUp()
        {
            matrix_1 = CreateRandom();
            matrix_2 = CreateRandom();
        }



        [Benchmark]
        public void Add()
        {
            result = Add(matrix_1,matrix_2);
        }

        [Benchmark]
        public void InAdd()
        {
            result = AddIn(in matrix_1, in matrix_2);
        }

        [Benchmark]
        public void OldAdd()
        {
            result = OldAdd(matrix_1,matrix_2);
        }
        /*
        [Benchmark]
        public void Multiply()
        {
            result = Multiply(matrix_1, matrix_2);
        }

        [Benchmark]
        public void InMultiply()
        {
            result = InMultiply(matrix_1, matrix_2);
        }
        */
    }




}
