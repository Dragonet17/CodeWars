using BenchmarkDotNet.Running;
using CodeWarts.Infrastructure.Implementations.PigIt;
using CodeWarts.Infrastructure.Implementations.ToCamelCase;

BenchmarkRunner.Run<ToCamelCaseBenchmark>();
Console.WriteLine("Hello, World!");
Console.ReadKey();
