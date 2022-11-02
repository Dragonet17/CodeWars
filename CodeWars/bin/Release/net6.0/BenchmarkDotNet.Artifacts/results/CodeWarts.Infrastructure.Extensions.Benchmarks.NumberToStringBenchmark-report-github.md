``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
|                  Method |       Mean |     Error |    StdDev |   Gen0 | Allocated |
|------------------------ |-----------:|----------:|----------:|-------:|----------:|
|          NumberToString | 16.4217 ns | 0.2436 ns | 0.2159 ns | 0.0076 |      48 B |
| NumberToStringWithDolar |  0.2089 ns | 0.0631 ns | 0.1153 ns |      - |         - |
