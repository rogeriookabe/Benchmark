```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
13th Gen Intel Core i7-13620H, 1 CPU, 16 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]        : .NET Core 2.1.30 (CoreCLR 4.6.30411.01, CoreFX 4.6.30411.02), X64 RyuJIT AVX2
  .NET 5.0      : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET 6.0      : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  .NET 7.0      : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  .NET Core 2.1 : .NET Core 2.1.30 (CoreCLR 4.6.30411.01, CoreFX 4.6.30411.02), X64 RyuJIT AVX2


```
| Method        | Job           | Runtime       | Mean      | Error    | StdDev   | Ratio        | RatioSD |
|-------------- |-------------- |-------------- |----------:|---------:|---------:|-------------:|--------:|
| Interpolation | .NET 5.0      | .NET 5.0      | 119.42 ns | 1.209 ns | 1.131 ns | 1.08x slower |   0.01x |
| Interpolation | .NET 6.0      | .NET 6.0      |  58.67 ns | 0.782 ns | 0.693 ns | 1.88x faster |   0.02x |
| Interpolation | .NET 7.0      | .NET 7.0      |  61.19 ns | 0.933 ns | 0.827 ns | 1.81x faster |   0.02x |
| Interpolation | .NET Core 2.1 | .NET Core 2.1 | 110.50 ns | 0.610 ns | 0.570 ns |     baseline |         |
