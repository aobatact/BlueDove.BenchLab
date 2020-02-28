using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    [SimpleJob(launchCount: 1, warmupCount: 3, targetCount: 5, id: "QuickJob")]
    public class ConsoleBench
    {
        private string[] values;

        [Params(100)]
        public int Length;

        private AsyncForgetWriter aw;
        private TextWriter w;

        [GlobalSetup]
        public void SetUp()
        {
            values = new string[Length];
            var random = new Random();
            for (int i = 0; i < Length; i++)
            {
                values[i] = random.Next().ToString();
            }
            w = System.Console.Out;
            aw = new AsyncForgetWriter(System.Console.Out, System.Console.Error);
        }

        [Benchmark]
        public void Console()
        {
            foreach (var value in values)
            {
                System.Console.WriteLine(value);
            }
        }

        [Benchmark]
        public void ForgetAsync()
        {
            foreach (var value in values)
            {
                aw.WriteLine(value);
            }
        }

        [Benchmark]
        public async Task Await()
        {
            foreach (var value in values)
            {
                await w.WriteLineAsync(value);
            }
        }

        [Benchmark]
        public async ValueTask VAwait()
        {
            foreach (var value in values)
            {
                await w.WriteLineAsync(value);
            }
        }

        [Benchmark]
        public void AwaitGetResult()
        {
            foreach (var value in values)
            {
                w.WriteLineAsync(value).GetAwaiter().GetResult();
            }
        }

        public class AsyncForgetWriter
        {
            private TextWriter w;
            private TextWriter e;

            public AsyncForgetWriter(TextWriter w, TextWriter e)
            {
                this.w = w;
                this.e = e;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void WriteLine(string str) { TaskUtil.FireAndForget(w.WriteLineAsync(str), x => e.WriteLine(x)); }
        }

        public static class TaskUtil
        {
            public static void FireAndForget(Task v, Action<Exception> writer = null)
            {
                v.ContinueWith(x => { writer?.Invoke(x.Exception); }, TaskContinuationOptions.OnlyOnFaulted);
            }
        }
    }
}
