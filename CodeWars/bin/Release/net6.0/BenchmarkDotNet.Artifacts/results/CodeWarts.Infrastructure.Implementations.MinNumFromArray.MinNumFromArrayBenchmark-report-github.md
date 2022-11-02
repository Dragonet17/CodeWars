``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |     Mean |    Error |   StdDev |   Gen0 |   Gen1 | Allocated |
|------- |---------:|---------:|---------:|-------:|-------:|----------:|
|   Min1 | 751.5 ns | 19.79 ns | 57.74 ns | 0.1383 |      - |     872 B |
|   Min2 | 828.0 ns | 28.49 ns | 83.10 ns | 0.1106 |      - |     696 B |
|   Min3 | 750.4 ns | 21.66 ns | 61.79 ns | 0.2317 | 0.0010 |    1456 B |
