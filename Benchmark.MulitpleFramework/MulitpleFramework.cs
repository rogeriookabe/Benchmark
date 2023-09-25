using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Benchmark.MulitpleFramework
{
    [Config(typeof(Config))]
    [SimpleJob(RuntimeMoniker.NetCoreApp21)]
    [SimpleJob(RuntimeMoniker.Net50, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class MulitpleFramework
    {
        private string Title = "Mr.", FirstName = "David", MiddleName = "Patrick", LastName = "Callan";

        [Benchmark]
        public string Interpolation()
        {
            return $"{Title} {FirstName} {MiddleName} {LastName} - {Title} {FirstName} {MiddleName} {LastName} - {Title} {FirstName} {MiddleName} {LastName}";
        }
    }
}