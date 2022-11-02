``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|      Method |     Mean |     Error |    StdDev |   Median |   Gen0 |   Gen1 | Allocated |
|------------ |---------:|----------:|----------:|---------:|-------:|-------:|----------:|
|     Reverse | 3.942 μs | 0.0875 μs | 0.2581 μs | 3.873 μs | 1.3428 | 0.0076 |   8.24 KB |
| ReverseSpan | 4.964 μs | 0.1449 μs | 0.4158 μs | 4.952 μs | 1.3428 | 0.0076 |   8.24 KB |
|    Reverse2 | 4.626 μs | 0.1864 μs | 0.5348 μs | 4.536 μs | 1.1139 |      - |   6.87 KB |
