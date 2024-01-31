# Search Algorithms Benchmarking in C#

This C# project provides implementations of two search algorithms, Binary Search and Linear Search, along with benchmarking to compare their performance.

## Table of Contents

- [Binary Search](#binary-search)
- [Linear Search](#linear-search)
- [Benchmarking](#benchmarking)
- [Usage](#usage)
- [License](#license)

## Binary Search

Binary Search is an efficient algorithm for finding an element in a sorted collection. It works by repeatedly dividing the search space in half.

### Implementation

The Binary Search algorithm is implemented in the `BinarySearchAlgorithm` class. The method signature is as follows:

```csharp
public static int Search(int[] array, int target)
```

## Linear Search

Linear Search is a simple algorithm for finding an element in a collection. It works by iterating over each element in the collection and comparing it to the target.

### Implementation

The Linear Search algorithm is implemented in the `LinearSearchAlgorithm` class. The method signature is as follows:

```csharp
public static int Search(int[] array, int target)
```

## Benchmarking

Benchmarking is the process of measuring the performance of an algorithm. This project uses the [BenchmarkDotNet]

```
BenchmarkDotNet v0.13.12, macOS Sonoma 14.3 (23D56) [Darwin 23.3.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT AdvSIMD
```
| Method       | TotalItems | Mean     | Error    | StdDev   | Median   |
|------------- |----------- |---------:|---------:|---------:|---------:|
| **BinarySearch** | **1000**       | **12.55 ns** | **0.039 ns** | **0.036 ns** | **12.54 ns** |
| LinearSearch | 1000       | 12.67 ns | 0.166 ns | 0.130 ns | 12.65 ns |
| **BinarySearch** | **1000000**    | **13.05 ns** | **0.364 ns** | **1.022 ns** | **12.67 ns** |
| LinearSearch | 1000000    | 13.67 ns | 0.372 ns | 1.044 ns | 13.48 ns |

## Usage

To run the benchmark, execute the following command:

```bash
dotnet run -c Release
```

## License

This project is licensed under the [MIT License](LICENSE). See the LICENSE file for details.