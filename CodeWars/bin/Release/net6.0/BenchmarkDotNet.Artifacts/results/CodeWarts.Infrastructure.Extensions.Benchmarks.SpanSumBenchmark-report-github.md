``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
|     CalculateFor |         NA |       NA |       NA |
| CalculateForEach |   166.3 ns |  3.32 ns |  4.77 ns |
|    CalculateLinq | 1,142.0 ns | 22.36 ns | 30.60 ns |

Benchmarks with issues:
  SpanSumBenchmark.CalculateFor: DefaultJob
