using BenchmarkDotNet.Running;
using CodeWarts.Infrastructure.Implementations.PigIt;

BenchmarkRunner.Run<PigItTestsBenchmark>();
Console.WriteLine("Hello, World!");
Console.ReadKey();
