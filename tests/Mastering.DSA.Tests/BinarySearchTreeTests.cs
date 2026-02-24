using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class BinarySearchTreeTests
{
    private BinarySearchTree.MyBinarySearchTree bst = null!;

    [SetUp]
    public void Setup()
    {
        bst = new BinarySearchTree.MyBinarySearchTree();
        bst.Insert(8);
        bst.Insert(3);
        bst.Insert(10);
        bst.Insert(1);
        bst.Insert(6);
    }

    [Test]
    public void Contains_ExistingValue_ReturnsTrue()
    {
        Assert.That(bst.Contains(6), Is.True);
        Assert.That(bst.Contains(8), Is.True);
        Assert.That(bst.Contains(1), Is.True);
    }

    [Test]
    public void Contains_NonExistingValue_ReturnsFalse()
    {
        Assert.That(bst.Contains(99), Is.False);
        Assert.That(bst.Contains(0), Is.False);
    }

    [Test]
    public void Delete_LeafNode()
    {
        bst.Delete(1);
        Assert.That(bst.Contains(1), Is.False);
        Assert.That(bst.Contains(3), Is.True); // parent still exists
    }

    [Test]
    public void Delete_NodeWithOneChild()
    {
        bst.Delete(10);
        Assert.That(bst.Contains(10), Is.False);
        Assert.That(bst.Contains(8), Is.True); // parent still exists
    }

    [Test]
    public void Delete_NodeWithTwoChildren()
    {
        bst.Delete(3); // has children 1 and 6
        Assert.That(bst.Contains(3), Is.False);
        Assert.That(bst.Contains(1), Is.True);
        Assert.That(bst.Contains(6), Is.True);
    }

    [Test]
    public void Insert_DuplicateValue_NoError()
    {
        bst.Insert(8); // already exists
        Assert.That(bst.Contains(8), Is.True);
    }
}
