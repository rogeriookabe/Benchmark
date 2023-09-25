using BenchmarkDotNet.Running;
using System;

namespace Benchmark.MulitpleFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MulitpleFramework>();
        }
    }
}
