using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class StackLinkedListTests
{
    private LIFO.StackUsingLinkedList stack = null!;

    [SetUp]
    public void Setup()
    {
        stack = new LIFO.StackUsingLinkedList();
    }

    [Test]
    public void Push_Pop_LIFO_Order()
    {
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Assert.That(stack.Pop(), Is.EqualTo(30));
        Assert.That(stack.Pop(), Is.EqualTo(20));
        Assert.That(stack.Pop(), Is.EqualTo(10));
    }

    [Test]
    public void Peek_ReturnsTopWithoutRemoving()
    {
        stack.Push(10);
        stack.Push(20);
        Assert.That(stack.Peek(), Is.EqualTo(20));
        Assert.That(stack.Peek(), Is.EqualTo(20));
    }

    [Test]
    public void IsEmpty_ReturnsTrue_WhenEmpty()
    {
        Assert.That(stack.IsEmpty(), Is.True);
    }

    [Test]
    public void Pop_EmptyStack_ReturnsNull()
    {
        Assert.That(stack.Pop(), Is.Null);
    }
}

[TestFixture]
public class ArrayStackTests
{
    [Test]
    public void Push_Pop_BasicOperation()
    {
        var stack = new LIFO.ArrayStack(5);
        stack.Push(10);
        stack.Push(20);
        Assert.That(stack.Pop(), Is.EqualTo(20));
        Assert.That(stack.Pop(), Is.EqualTo(10));
    }

    [Test]
    public void Push_Overflow_Throws()
    {
        var stack = new LIFO.ArrayStack(1);
        stack.Push(10);
        Assert.Throws<Exception>(() => stack.Push(20));
    }

    [Test]
    public void Pop_Underflow_Throws()
    {
        var stack = new LIFO.ArrayStack(1);
        Assert.Throws<Exception>(() => stack.Pop());
    }

    [Test]
    public void Peek_ReturnsTopElement()
    {
        var stack = new LIFO.ArrayStack(5);
        stack.Push(10);
        stack.Push(20);
        Assert.That(stack.Peek(), Is.EqualTo(20));
    }
}
