using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    [MemoryDiagnoser]
    public class RosOptimization
    {
        private static readonly byte[] ArrayBytes = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        private static ReadOnlySpan<byte> RosBytes => new byte[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        private int x;
        
        [Benchmark]
        public void UseArrayForEach()
        {
            foreach (var arrayByte in ArrayBytes)
            {
                x += arrayByte;
            }
        }        
                
        [Benchmark]
        public void UseArrayFor()
        {
            for (var i = 0; i < ArrayBytes.Length; i++)
            {
                x += ArrayBytes[i];
            }
        }        
        
        [Benchmark]
        public void UseRosForEach()
        {
            foreach (var rosByte in RosBytes)
            {
                x += rosByte;
            }
        }        
        
        [Benchmark]
        public void UseRosFor()
        {
            for (var i = 0; i < RosBytes.Length; i++)
            {
                x += RosBytes[i];
            }
        }
    }
}