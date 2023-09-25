```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
13th Gen Intel Core i7-13620H, 1 CPU, 16 logical and 10 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method        | Mean         | Error       | StdDev      | Ratio          | RatioSD | Allocated | Alloc Ratio |
|-------------- |-------------:|------------:|------------:|---------------:|--------:|----------:|------------:|
| BubbleSort    |     445.7 ns |     2.76 ns |     2.45 ns |       baseline |         |         - |          NA |
| InsertionSort |     632.0 ns |     9.83 ns |     8.21 ns |   1.42x slower |   0.02x |         - |          NA |
| SelectionSort | 174,442.1 ns | 1,586.40 ns | 1,483.92 ns | 391.30x slower |   4.93x |         - |          NA |
