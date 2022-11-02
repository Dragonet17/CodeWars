``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |    Number |     Mean |    Error |   StdDev |   Median |   Gen0 | Allocated |
|------- |---------- |---------:|---------:|---------:|---------:|-------:|----------:|
|   Num1 | 987654321 | 147.8 ns |  2.90 ns |  3.34 ns | 146.8 ns | 0.0370 |     232 B |
|   Num2 | 987654321 | 547.7 ns | 25.19 ns | 74.27 ns | 505.0 ns | 0.1006 |     632 B |
