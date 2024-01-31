using Algorithms.Interfaces;

namespace Algorithms;

/// <summary>
///    Linear search algorithm.
///    Complexity: O(n)
///    Worst-case performance: O(n)
///    Best-case performance: O(1)
/// </summary>
public abstract class LinearSearchAlgorithm : ISearchAlgorithm
{
    public static int Search(int[] array, int target)
    {
        if (array.Length == 0)
            return -1;
        
        if (target < array[0] || target > array[^1])
            return -1;
        
        for (var i = 0; i < array.Length; i++)
            if (array[i] == target)
                return i;

        return -1;
    }
}