namespace SortingAlgorithms;

public class MinHeap
{
    private List<int> heap = new List<int>();

    public void Enqueue(int value)
    {
        heap.Add(value);
        BubbleUp(heap.Count - 1);
    }

    private void BubbleUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;

            if (heap[parentIndex] <= heap[index])
                break;

            Swap(parentIndex, index);
            index = parentIndex;
        }
    }

    public int Dequeue()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        int root = heap[0];

        heap[0] = heap[^1];
        heap.RemoveAt(heap.Count - 1);

        HeapifyDown(0);

        return root;
    }

    private void HeapifyDown(int index)
    {
        int lastIndex = heap.Count - 1;

        while (true)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int smallest = index;

            if (left <= lastIndex && heap[left] < heap[smallest])
                smallest = left;

            if (right <= lastIndex && heap[right] < heap[smallest])
                smallest = right;

            if (smallest == index)
                break;

            Swap(index, smallest);
            index = smallest;
        }
    }

    private void Swap(int i, int j)
    {
        (heap[i], heap[j]) = (heap[j], heap[i]);
    }

    public int Peek()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        return heap[0];
    }
}
// test in main
//var pq = new MinHeap();

//pq.Enqueue(10);
//pq.Enqueue(5);
//pq.Enqueue(20);
//pq.Enqueue(1);

//Console.WriteLine(pq.Dequeue()); // 1
//Console.WriteLine(pq.Dequeue()); // 5
//Console.WriteLine(pq.Dequeue()); // 10
//Console.WriteLine(pq.Dequeue()); // 20
