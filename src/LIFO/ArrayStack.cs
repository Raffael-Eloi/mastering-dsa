namespace LIFO;

public class ArrayStack
{
    private int[] items;
    private int top = -1;

    public ArrayStack(int size)
    {
        items = new int[size];
    }

    public void Push(int value)
    {
        if (top == items.Length - 1)
            throw new Exception("Stack overflow");

        items[++top] = value;
    }

    public int Pop()
    {
        if (top == -1)
            throw new Exception("Stack underflow");

        return items[top--];
    }

    public int Peek()
    {
        return items[top];
    }
}