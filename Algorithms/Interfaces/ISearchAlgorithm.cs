namespace Algorithms.Interfaces;

/// <summary>
///  Search algorithm interface.
/// </summary>
public interface ISearchAlgorithm
{
    /// <summary>
    /// Performs a search operation on an array to find the specified target.
    /// </summary>
    /// <param name="array">The array to search.</param>
    /// <param name="target">The target value to find in the array.</param>
    /// <returns>
    /// The index of the target element if found; otherwise, returns -1.
    /// </returns>
    static int Search(int[] array, int target) => -1;
}