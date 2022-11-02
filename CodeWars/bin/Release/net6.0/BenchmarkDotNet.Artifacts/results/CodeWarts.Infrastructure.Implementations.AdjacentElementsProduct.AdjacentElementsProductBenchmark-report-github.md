``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |    array |      Mean |     Error |   StdDev |    Median |   Gen0 | Allocated |
|------- |--------- |----------:|----------:|---------:|----------:|-------:|----------:|
|  Test1 | Int32[9] |  79.95 ns |  3.921 ns | 11.19 ns |  80.54 ns | 0.0139 |      88 B |
|  Test2 | Int32[9] | 198.87 ns | 11.695 ns | 34.11 ns | 196.59 ns | 0.0331 |     208 B |
|  Test3 | Int32[9] | 209.38 ns |  7.550 ns | 21.90 ns | 200.75 ns | 0.0279 |     176 B |
