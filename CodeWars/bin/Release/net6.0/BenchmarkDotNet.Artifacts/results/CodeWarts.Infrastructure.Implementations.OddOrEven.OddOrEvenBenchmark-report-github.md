``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |     array |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|------- |---------- |----------:|----------:|----------:|-------:|----------:|
|   Sum1 | Int32[16] | 65.990 ns | 1.3264 ns | 1.5275 ns | 0.0050 |      32 B |
|   Sum2 | Int32[16] |  5.900 ns | 0.1681 ns | 0.1651 ns |      - |         - |
