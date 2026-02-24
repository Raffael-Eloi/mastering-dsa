namespace LinkedList;

public class MyLinkedList
{
    private Node? head;

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