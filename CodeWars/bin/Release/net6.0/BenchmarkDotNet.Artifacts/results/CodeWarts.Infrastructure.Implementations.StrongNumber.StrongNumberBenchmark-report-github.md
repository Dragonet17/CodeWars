``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|          Method |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|---------------- |----------:|---------:|---------:|-------:|----------:|
|       NumberFor |  17.33 ns | 0.253 ns | 0.281 ns | 0.0051 |      32 B |
| NumberAggregate | 120.54 ns | 2.461 ns | 2.181 ns | 0.0241 |     152 B |
