``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |               value |     Mean |     Error |    StdDev |   Median |
|------- |-------------------- |---------:|----------:|----------:|---------:|
|  Test1 | Lore(...)que. [664] | 4.255 μs | 0.1193 μs | 0.3499 μs | 4.104 μs |
|  Test2 | Lore(...)que. [664] | 7.043 μs | 0.1238 μs | 0.1034 μs | 7.073 μs |
