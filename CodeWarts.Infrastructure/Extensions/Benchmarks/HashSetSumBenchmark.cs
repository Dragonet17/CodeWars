﻿using BenchmarkDotNet.Attributes;

namespace CodeWarts.Infrastructure.Extensions.Benchmarks;

public class HashSetSumBenchmark
{
    private HashSet<int> numbers =new HashSet<int>( new int[]
    {
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        5254, 545, 6656, 54, 254, 858, 25, 154, 666, 588, 444, 222, 554, 6684, 485, 894, 545, 654, 87, 931, 857, 2496,
        2541, 25514, 185, 548, 56, 211, 6498, 2156, 5122, 56
    });

    [Benchmark]
    public int CalculateFor() => HashSetSum.CalculateForEach(numbers);

    [Benchmark]
    public int CalculateForEach() => HashSetSum.CalculateForEach(numbers);

    [Benchmark]
    public int CalculateLinq() => HashSetSum.CalculateLinq(numbers);
}