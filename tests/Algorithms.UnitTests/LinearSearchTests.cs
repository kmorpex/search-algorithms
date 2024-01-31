namespace Algorithms.UnitTests;

[TestFixture]
public class LinearSearchTests
{
    private int[] _sortedArray = Array.Empty<int>();

    [SetUp]
    public void Setup()
    {
        _sortedArray = Enumerable.Range(1, 100).ToArray();
    }

    [Test]
    public void LinearSearch_WhenTargetExists_ShouldReturnCorrectIndex()
    {
        const int target = 42;
        int result = LinearSearchAlgorithm.Search(_sortedArray, target);

        Assert.AreEqual(41, result);
    }

    [Test]
    public void LinearSearch_WhenTargetDoesNotExist_ShouldReturnMinusOne()
    {
        const int target = 101;
        int result = LinearSearchAlgorithm.Search(_sortedArray, target);

        Assert.AreEqual(-1, result);
    }
    
    [Test]
    public void LinearSearch_WhenArrayIsEmpty_ShouldReturnMinusOne()
    {
        const int target = 5;
        int result = LinearSearchAlgorithm.Search(Array.Empty<int>(), target);

        Assert.AreEqual(-1, result);
    }
}