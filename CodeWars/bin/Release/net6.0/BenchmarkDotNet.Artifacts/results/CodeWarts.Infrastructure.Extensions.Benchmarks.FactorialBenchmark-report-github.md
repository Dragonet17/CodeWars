``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|     Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------- |----------:|----------:|----------:|-------:|----------:|
|  Calculate |  4.361 ns | 0.1020 ns | 0.2107 ns |      - |         - |
| Calculate2 | 73.349 ns | 1.4298 ns | 1.4683 ns | 0.0063 |      40 B |
| Calculate3 |  5.693 ns | 0.1350 ns | 0.2758 ns |      - |         - |
