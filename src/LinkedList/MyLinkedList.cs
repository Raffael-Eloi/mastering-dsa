namespace LinkedList;

public class MyLinkedList
{
    private Node? head;

    // O(1) - insert at the beginning
    public void AddFirst(int value)
    {
        var newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
    }

    // O(n) - must traverse to find the end
    public void AddLast(int value)
    {
        var newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            return;
        }

        var current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    // O(1) - remove from the beginning
    public int? RemoveFirst()
    {
        if (head == null)
            return null;

        int value = head.Value;
        head = head.Next;
        return value;
    }

    // O(n) - must traverse to find second-to-last
    public int? RemoveLast()
    {
        if (head == null)
            return null;

        if (head.Next == null)
        {
            int value = head.Value;
            head = null;
            return value;
        }

        var current = head;
        while (current.Next!.Next != null)
        {
            current = current.Next;
        }

        int lastValue = current.Next.Value;
        current.Next = null;
        return lastValue;
    }

    // O(n) - must traverse to search
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

    // O(n) - must traverse to count
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

    public void Print()
    {
        var current = head;

        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }
}
