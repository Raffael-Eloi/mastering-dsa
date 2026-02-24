namespace FIFO;

public class QueueUsingLinkedList
{
    private Node? head;
    private Node? tail;

    public void Enqueue(int value)
    {
        var newNode = new Node(value);

        if (tail != null)
            tail.Next = newNode;

        tail = newNode;

        if (head == null)
            head = newNode;
    }

    public int? Dequeue()
    {
        if (head == null)
            return null;

        int value = head.Value;
        head = head.Next;

        if (head == null)
            tail = null;

        return value;
    }

    public int? Peek()
    {
        return head?.Value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}