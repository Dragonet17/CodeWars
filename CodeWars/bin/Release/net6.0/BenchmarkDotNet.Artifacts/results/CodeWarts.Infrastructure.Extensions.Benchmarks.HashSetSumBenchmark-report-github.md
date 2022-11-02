``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|           Method |      Mean |    Error |    StdDev |    Median |
|----------------- |----------:|---------:|----------:|----------:|
|     CalculateFor |  62.11 ns | 1.453 ns |  3.977 ns |  61.57 ns |
| CalculateForEach |  72.42 ns | 4.410 ns | 13.003 ns |  66.95 ns |
|    CalculateLinq | 201.62 ns | 4.104 ns |  9.430 ns | 198.04 ns |
