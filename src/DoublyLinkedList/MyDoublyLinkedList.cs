namespace DoublyLinkedList;

public class MyDoublyLinkedList
{
    private DoublyNode? head;
    private DoublyNode? tail;

    // O(1) - insert at the beginning
    public void AddFirst(int value)
    {
        var newNode = new DoublyNode(value);

        if (head == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Previous = newNode;
        head = newNode;
    }

    // O(1) - insert at the end (we track tail)
    public void AddLast(int value)
    {
        var newNode = new DoublyNode(value);

        if (tail == null)
        {
            head = tail = newNode;
            return;
        }

        newNode.Previous = tail;
        tail.Next = newNode;
        tail = newNode;
    }

    // O(1) - remove from the beginning
    public int? RemoveFirst()
    {
        if (head == null)
            return null;

        int value = head.Value;

        if (head == tail)
        {
            head = tail = null;
            return value;
        }

        head = head.Next;
        head!.Previous = null;
        return value;
    }

    // O(1) - remove from the end (we track tail)
    public int? RemoveLast()
    {
        if (tail == null)
            return null;

        int value = tail.Value;

        if (head == tail)
        {
            head = tail = null;
            return value;
        }

        tail = tail.Previous;
        tail!.Next = null;
        return value;
    }

    // O(n) - must traverse to find
    public bool Contains(int value)
    {
        var current = head;
        while (current != null)
        {
            if (current.Value == value)
                return true;
            current = current.Next;
        }
        return false;
    }

    // O(n)
    public int Count()
    {
        int count = 0;
        var current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // Print head -> tail
    public void PrintForward()
    {
        var current = head;
        while (current != null)
        {
            Console.Write(current.Value + " <-> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    // Print tail -> head
    public void PrintReverse()
    {
        var current = tail;
        while (current != null)
        {
            Console.Write(current.Value + " <-> ");
            current = current.Previous;
        }
        Console.WriteLine("null");
    }
}
