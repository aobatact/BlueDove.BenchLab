using BenchmarkDotNet.Attributes;
using System;

namespace BlueDove.BenchLab
{
    public partial class DIMBenchOld
    {
        interface INonDim
        {
            int Add(int x, int y);
        }

        interface IDim
        {
            int Add(int x, int y);
            
            virtual int AddDim(int x, int y)
            {
                return x + y;
            }
        }

        class NonDimClass : INonDim
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }

        struct NonDimStruct : INonDim
        {
            public int Add(int x, int y) => x + y;
        }

        class DimUsingClass : IDim
        {
            public int Add(int x, int y) => x + y;
        }

        class DimOverrideClass : IDim
        {
            public int Add(int x, int y) => x + y;

            public int AddDim(int x, int y) => x + y;
        }

        struct DimUsingStruct : IDim
        {
            public int Add(int x, int y) => x + y;
        }

        struct DimOverrideStruct : IDim
        {
            public int Add(int x, int y) => x + y;

            public int AddDim(int x, int y) => x+y;
        }

        private int res;
        private int x;
        private int y;

        
        
        [GlobalSetup]
        public void SetUp()
        {
            var ran = new Random();
            x = ran.Next();
            y = ran.Next();
        }
    }
}
