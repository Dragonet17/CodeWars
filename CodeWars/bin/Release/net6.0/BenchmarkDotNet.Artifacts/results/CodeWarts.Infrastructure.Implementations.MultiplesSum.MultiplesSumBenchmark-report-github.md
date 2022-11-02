``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|        Method |      Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|-------------- |----------:|----------:|----------:|-------:|-------:|----------:|
|           Sum | 24.677 μs | 0.4766 μs | 0.6986 μs | 0.6714 |      - |    4344 B |
|   DistinctSum | 12.810 μs | 0.5860 μs | 1.7093 μs | 5.7526 | 0.3815 |   36136 B |
| SumEnumerable |  6.535 μs | 0.1178 μs | 0.1102 μs | 0.0153 |      - |      96 B |
