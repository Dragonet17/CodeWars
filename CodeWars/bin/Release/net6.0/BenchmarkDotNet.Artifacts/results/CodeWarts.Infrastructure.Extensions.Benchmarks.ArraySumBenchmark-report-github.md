``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|           Method |     Mean |    Error |    StdDev |   Median |   Gen0 | Allocated |
|----------------- |---------:|---------:|----------:|---------:|-------:|----------:|
|    CalculateFor1 |       NA |       NA |        NA |       NA |      - |         - |
| CalculateForEach | 105.8 ns |  3.81 ns |  10.49 ns | 106.1 ns |      - |         - |
|    CalculateLinq | 975.5 ns | 83.78 ns | 247.03 ns | 866.6 ns | 0.0038 |      32 B |

Benchmarks with issues:
  ArraySumBenchmark.CalculateFor1: DefaultJob
