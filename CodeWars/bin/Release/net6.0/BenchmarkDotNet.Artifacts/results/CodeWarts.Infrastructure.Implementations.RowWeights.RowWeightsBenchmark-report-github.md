``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |     Mean |   Error |  StdDev |   Median |
|------- |---------:|--------:|--------:|---------:|
|  Calc1 | 373.9 ns | 7.55 ns | 8.70 ns | 374.7 ns |
|  Calc2 | 198.0 ns | 3.93 ns | 9.86 ns | 193.0 ns |
