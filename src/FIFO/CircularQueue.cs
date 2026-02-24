namespace FIFO;

// If you do naive array queue, you’ll shift elements → O(n)
// Better: circular buffer.
public class CircularQueue
{
    private int[] items;
    private int front = 0;
    private int rear = 0;
    private int count = 0;

    public CircularQueue(int size)
    {
        items = new int[size];
    }

    public void Enqueue(int value)
    {
        if (count == items.Length)
            throw new Exception("Queue full");

        items[rear] = value;
        rear = (rear + 1) % items.Length;
        count++;
    }

    public int Dequeue()
    {
        if (count == 0)
            throw new Exception("Queue empty");

        int value = items[front];
        front = (front + 1) % items.Length;
        count--;
        return value;
    }
}

// This keeps:
// Enqueue → O(1)
// Dequeue → O(1)