using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class DoublyLinkedListTests
{
    private DoublyLinkedList.MyDoublyLinkedList list = null!;

    [SetUp]
    public void Setup()
    {
        list = new DoublyLinkedList.MyDoublyLinkedList();
    }

    [Test]
    public void AddFirst_AddLast_CorrectOrder()
    {
        list.AddLast(20);
        list.AddFirst(10);
        list.AddLast(30);
        Assert.That(list.Count(), Is.EqualTo(3));
        Assert.That(list.RemoveFirst(), Is.EqualTo(10));
        Assert.That(list.RemoveLast(), Is.EqualTo(30));
    }

    [Test]
    public void RemoveFirst_EmptyList_ReturnsNull()
    {
        Assert.That(list.RemoveFirst(), Is.Null);
    }

    [Test]
    public void RemoveLast_EmptyList_ReturnsNull()
    {
        Assert.That(list.RemoveLast(), Is.Null);
    }

    [Test]
    public void RemoveLast_IsO1_WithTailPointer()
    {
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        Assert.That(list.RemoveLast(), Is.EqualTo(30));
        Assert.That(list.RemoveLast(), Is.EqualTo(20));
        Assert.That(list.RemoveLast(), Is.EqualTo(10));
        Assert.That(list.Count(), Is.EqualTo(0));
    }

    [Test]
    public void Contains_FindsExistingValue()
    {
        list.AddLast(10);
        list.AddLast(20);
        Assert.That(list.Contains(20), Is.True);
        Assert.That(list.Contains(99), Is.False);
    }

    [Test]
    public void SingleElement_RemoveFirst_And_RemoveLast()
    {
        list.AddLast(42);
        Assert.That(list.RemoveFirst(), Is.EqualTo(42));
        Assert.That(list.Count(), Is.EqualTo(0));

        list.AddLast(42);
        Assert.That(list.RemoveLast(), Is.EqualTo(42));
        Assert.That(list.Count(), Is.EqualTo(0));
    }
}
