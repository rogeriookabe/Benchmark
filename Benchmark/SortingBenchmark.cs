using BenchmarkDotNet.Attributes;
using System;

namespace Benchmark; 

[Config(typeof(Config))]
[MemoryDiagnoser]
public class SortingBenchmark
{
    public int[] Numbers { get; set; }
    public Sorting Sorting { get; set; } = new Sorting();

    public SortingBenchmark()
    {
        Numbers = PopulateArray();
    }

    public int[] PopulateArray()
    {
        var rnd = new Random();
        var numbers = new int[1000];
        for (int i = 0; i < 1000; i++)
            numbers[i] = rnd.Next(-100, 101);
        return numbers;
    }

    [Benchmark(Baseline = true)]
    public void BubbleSort()
    {
        Sorting.BubbleSort(Numbers);
    }

    [Benchmark]
    public void InsertionSort()
    {
        Sorting.InsertionSort(Numbers);
    }

    [Benchmark]
    public void SelectionSort()
    {
        Sorting.SelectionSort(Numbers);
    }
}