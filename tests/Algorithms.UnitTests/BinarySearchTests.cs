namespace Algorithms.UnitTests;

[TestFixture]
public class BinarySearchTests
{
    private int[] _sortedArray = Array.Empty<int>();

    [SetUp]
    public void Setup()
    {
        _sortedArray = Enumerable.Range(1, 100).ToArray();
    }

    [Test]
    public void BinarySearch_WhenTargetExists_ShouldReturnCorrectIndex()
    {
        const int target = 42;
        int result = BinarySearchAlgorithm.Search(_sortedArray, target);

        Assert.AreEqual(41, result);
    }

    [Test]
    public void BinarySearch_WhenTargetDoesNotExist_ShouldReturnMinusOne()
    {
        const int target = 101;
        int result = BinarySearchAlgorithm.Search(_sortedArray, target);

        Assert.AreEqual(-1, result);
    }
    
    [Test]
    public void BinarySearch_WhenArrayIsEmpty_ShouldReturnMinusOne()
    {
        const int target = 5;
        int result = BinarySearchAlgorithm.Search(Array.Empty<int>(), target);

        Assert.AreEqual(-1, result);
    }
}