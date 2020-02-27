using BenchmarkDotNet.Running;

namespace BlueDove.BenchLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly);
            switcher.Run(args);
        }

    }
}
