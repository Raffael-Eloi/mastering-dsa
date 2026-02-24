using NUnit.Framework;

namespace Mastering.DSA.Tests;

[TestFixture]
public class QueueLinkedListTests
{
    private FIFO.QueueUsingLinkedList queue = null!;

    [SetUp]
    public void Setup()
    {
        queue = new FIFO.QueueUsingLinkedList();
    }

    [Test]
    public void Enqueue_Dequeue_FIFO_Order()
    {
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Assert.That(queue.Dequeue(), Is.EqualTo(10));
        Assert.That(queue.Dequeue(), Is.EqualTo(20));
        Assert.That(queue.Dequeue(), Is.EqualTo(30));
    }

    [Test]
    public void Peek_ReturnsFirstWithoutRemoving()
    {
        queue.Enqueue(10);
        queue.Enqueue(20);
        Assert.That(queue.Peek(), Is.EqualTo(10));
        Assert.That(queue.Peek(), Is.EqualTo(10)); // still there
    }

    [Test]
    public void IsEmpty_ReturnsTrue_WhenEmpty()
    {
        Assert.That(queue.IsEmpty(), Is.True);
    }

    [Test]
    public void IsEmpty_ReturnsFalse_WhenNotEmpty()
    {
        queue.Enqueue(10);
        Assert.That(queue.IsEmpty(), Is.False);
    }

    [Test]
    public void Dequeue_EmptyQueue_ReturnsNull()
    {
        Assert.That(queue.Dequeue(), Is.Null);
    }
}

[TestFixture]
public class CircularQueueTests
{
    [Test]
    public void Enqueue_Dequeue_BasicOperation()
    {
        var queue = new FIFO.CircularQueue(3);
        queue.Enqueue(10);
        queue.Enqueue(20);
        Assert.That(queue.Dequeue(), Is.EqualTo(10));
        Assert.That(queue.Dequeue(), Is.EqualTo(20));
    }

    [Test]
    public void CircularWraparound_Works()
    {
        var queue = new FIFO.CircularQueue(3);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue(); // free a slot
        queue.Enqueue(4); // wraps around
        Assert.That(queue.Dequeue(), Is.EqualTo(2));
        Assert.That(queue.Dequeue(), Is.EqualTo(3));
        Assert.That(queue.Dequeue(), Is.EqualTo(4));
    }

    [Test]
    public void Enqueue_FullQueue_Throws()
    {
        var queue = new FIFO.CircularQueue(2);
        queue.Enqueue(1);
        queue.Enqueue(2);
        Assert.Throws<Exception>(() => queue.Enqueue(3));
    }

    [Test]
    public void Dequeue_EmptyQueue_Throws()
    {
        var queue = new FIFO.CircularQueue(2);
        Assert.Throws<Exception>(() => queue.Dequeue());
    }
}
