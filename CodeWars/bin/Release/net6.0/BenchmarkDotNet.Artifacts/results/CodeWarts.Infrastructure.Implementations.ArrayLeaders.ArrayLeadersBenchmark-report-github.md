``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |     Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|------- |---------:|----------:|----------:|-------:|-------:|----------:|
|  Lead1 | 1.098 μs | 0.0136 μs | 0.0127 μs | 0.9327 | 0.0191 |   5.72 KB |
|  Lead2 | 1.265 μs | 0.0253 μs | 0.0597 μs | 0.9327 | 0.0191 |   5.72 KB |
