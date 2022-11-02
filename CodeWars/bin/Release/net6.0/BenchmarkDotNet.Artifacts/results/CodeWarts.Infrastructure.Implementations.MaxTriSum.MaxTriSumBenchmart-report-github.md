``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|     Method |     Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|----------- |---------:|----------:|----------:|-------:|-------:|----------:|
|  Calculate | 1.371 μs | 0.0273 μs | 0.0675 μs | 0.3109 | 0.0019 |   1.91 KB |
| Calculate2 | 1.692 μs | 0.0409 μs | 0.1159 μs | 0.4349 | 0.0019 |   2.67 KB |
| Calculate3 | 1.628 μs | 0.0388 μs | 0.1120 μs | 0.4349 | 0.0019 |   2.67 KB |
