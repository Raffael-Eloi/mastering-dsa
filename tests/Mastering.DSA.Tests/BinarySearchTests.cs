using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class BinarySearchTests
{
    private readonly int[] sorted = { 1, 3, 5, 7, 9, 11, 13, 15 };

    [Test]
    public void Search_FindsExistingElement()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(sorted, 7), Is.EqualTo(3));
    }

    [Test]
    public void Search_FirstElement()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(sorted, 1), Is.EqualTo(0));
    }

    [Test]
    public void Search_LastElement()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(sorted, 15), Is.EqualTo(7));
    }

    [Test]
    public void Search_NonExistent_ReturnsMinusOne()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(sorted, 8), Is.EqualTo(-1));
    }

    [Test]
    public void SearchRecursive_FindsExistingElement()
    {
        Assert.That(BinarySearch.MyBinarySearch.SearchRecursive(sorted, 7, 0, sorted.Length - 1), Is.EqualTo(3));
    }

    [Test]
    public void SearchRecursive_NonExistent_ReturnsMinusOne()
    {
        Assert.That(BinarySearch.MyBinarySearch.SearchRecursive(sorted, 100, 0, sorted.Length - 1), Is.EqualTo(-1));
    }

    [Test]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(Array.Empty<int>(), 5), Is.EqualTo(-1));
    }

    [Test]
    public void Search_SingleElement_Found()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(new[] { 42 }, 42), Is.EqualTo(0));
    }

    [Test]
    public void Search_SingleElement_NotFound()
    {
        Assert.That(BinarySearch.MyBinarySearch.Search(new[] { 42 }, 1), Is.EqualTo(-1));
    }
}
