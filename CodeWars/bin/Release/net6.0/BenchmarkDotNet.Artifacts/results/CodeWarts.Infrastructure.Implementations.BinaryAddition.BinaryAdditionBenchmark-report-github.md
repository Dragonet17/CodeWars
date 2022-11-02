``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|      Method |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------ |----------:|---------:|---------:|-------:|----------:|
|     Convert | 294.84 ns | 2.687 ns | 2.244 ns | 0.0191 |     120 B |
| ConvertBest |  61.92 ns | 0.363 ns | 0.322 ns | 0.0088 |      56 B |
