``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|            Method |      Mean |    Error |    StdDev |   Gen0 | Allocated |
|------------------ |----------:|---------:|----------:|-------:|----------:|
|     MinimumNumber |  56.81 ns | 0.961 ns |  1.107 ns | 0.0127 |      80 B |
| MinimumNumberBest | 233.62 ns | 4.671 ns | 11.633 ns | 0.0381 |     240 B |
