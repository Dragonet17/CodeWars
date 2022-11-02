``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.856/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|          Method |      Mean |    Error |   StdDev |   Gen0 | Allocated |
|---------------- |----------:|---------:|---------:|-------:|----------:|
|           Parse | 107.62 ns | 1.356 ns | 1.268 ns | 0.0114 |      72 B |
| ParseDictionary | 500.03 ns | 9.525 ns | 7.954 ns | 0.1440 |     904 B |
|       ParseList |  44.87 ns | 0.950 ns | 1.131 ns | 0.0178 |     112 B |
