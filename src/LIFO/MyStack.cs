namespace LIFO;

public class MyStack
{
    private Node? top;

    public void Push(int value)
    {
        var newNode = new Node(value);
        newNode.Next = top;
        top = newNode;
    }

    public int? Pop()
    {
        if (top == null)
            return null;

        int value = top.Value;
        top = top.Next;
        return value;
    }

    public int? Peek()
    {
        return top?.Value;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}
