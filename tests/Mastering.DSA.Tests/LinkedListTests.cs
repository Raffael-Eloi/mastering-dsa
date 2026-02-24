using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class LinkedListTests
{
    private LinkedList.MyLinkedList list = null!;

    [SetUp]
    public void Setup()
    {
        list = new LinkedList.MyLinkedList();
    }

    [Test]
    public void AddLast_AddsElementsInOrder()
    {
        list.AddLast(10);
        list.AddLast(20);
        Assert.That(list.Contains(10), Is.True);
        Assert.That(list.Contains(20), Is.True);
        Assert.That(list.Count(), Is.EqualTo(2));
    }

    [Test]
    public void AddFirst_AddsElementAtBeginning()
    {
        list.AddLast(20);
        list.AddFirst(10);
        Assert.That(list.Count(), Is.EqualTo(2));
        Assert.That(list.RemoveFirst(), Is.EqualTo(10));
    }

    [Test]
    public void RemoveFirst_ReturnsFirstElement()
    {
        list.AddLast(10);
        list.AddLast(20);
        Assert.That(list.RemoveFirst(), Is.EqualTo(10));
        Assert.That(list.Count(), Is.EqualTo(1));
    }

    [Test]
    public void RemoveFirst_EmptyList_ReturnsNull()
    {
        Assert.That(list.RemoveFirst(), Is.Null);
    }

    [Test]
    public void RemoveLast_ReturnsLastElement()
    {
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        Assert.That(list.RemoveLast(), Is.EqualTo(30));
        Assert.That(list.Count(), Is.EqualTo(2));
    }

    [Test]
    public void RemoveLast_SingleElement_ReturnsElement()
    {
        list.AddLast(10);
        Assert.That(list.RemoveLast(), Is.EqualTo(10));
        Assert.That(list.Count(), Is.EqualTo(0));
    }

    [Test]
    public void Contains_ReturnsTrueForExisting()
    {
        list.AddLast(10);
        list.AddLast(20);
        Assert.That(list.Contains(20), Is.True);
    }

    [Test]
    public void Contains_ReturnsFalseForMissing()
    {
        list.AddLast(10);
        Assert.That(list.Contains(99), Is.False);
    }

    [Test]
    public void Count_EmptyList_ReturnsZero()
    {
        Assert.That(list.Count(), Is.EqualTo(0));
    }
}
