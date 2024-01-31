using Algorithms;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Configurations;

public class SearchBenchmark
{
    [Params(1000, 1000000)] 
    public int TotalItems { get; set; }
    private int Target => (int)(TotalItems - TotalItems * 10m);
    private static int[] SortedArray { get; set; } = Array.Empty<int>();

    [GlobalSetup]
    public void Setup()
    {
        SortedArray = Enumerable.Range(0, TotalItems).ToArray();
        Array.Sort(SortedArray);
    }

    [Benchmark]
    public void BinarySearch()
    {
        BinarySearchAlgorithm.Search(SortedArray, Target);
    }

    [Benchmark]
    public void LinearSearch()
    {
        LinearSearchAlgorithm.Search(SortedArray, Target);
    }
}