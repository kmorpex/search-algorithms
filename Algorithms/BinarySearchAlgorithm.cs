using Algorithms.Interfaces;

namespace Algorithms;

/// <summary>
///    Binary search algorithm.
///    Complexity: O(log n)
///    Worst-case performance: O(log n)
///    Best-case performance: O(1)
/// </summary>
public abstract class BinarySearchAlgorithm : ISearchAlgorithm
{
    public static int Search(int[] array, int target)
    {
        if (array.Length == 0)
            return -1;
        
        if (target < array[0] || target > array[^1])
            return -1;

        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;

            if (array[middle] == target)
                return middle;
            if (array[middle] > target)
                right = middle - 1;
            else
                left = middle + 1;
        }

        return -1;
    }
}