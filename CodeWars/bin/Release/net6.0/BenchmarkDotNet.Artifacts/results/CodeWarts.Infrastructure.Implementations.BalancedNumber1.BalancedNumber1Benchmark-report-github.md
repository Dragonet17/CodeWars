``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.978/21H2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT AVX2


```
| Method |      Mean |    Error |    StdDev |    Median |   Gen0 | Allocated |
|------- |----------:|---------:|----------:|----------:|-------:|----------:|
|     My | 199.67 ns | 3.977 ns |  7.171 ns | 197.76 ns | 0.0343 |     216 B |
|    My2 | 184.44 ns | 5.517 ns | 16.180 ns | 178.11 ns | 0.0930 |     584 B |
| My2Sum |  23.98 ns | 0.527 ns |  0.804 ns |  23.86 ns | 0.0063 |      40 B |
|  Best1 | 207.09 ns | 4.182 ns |  8.912 ns | 206.61 ns | 0.0470 |     296 B |
|  Best2 | 353.42 ns | 9.976 ns | 28.300 ns | 349.42 ns | 0.0534 |     336 B |
| Other1 |  97.74 ns | 2.746 ns |  7.835 ns |  94.45 ns | 0.0395 |     248 B |
| Other2 |  36.47 ns | 0.768 ns |  1.051 ns |  36.37 ns | 0.0357 |     224 B |
