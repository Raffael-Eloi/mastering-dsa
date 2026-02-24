using SortingAlgorithms;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Sorting Algorithms ===\n");

        // -----------------------------------------
        // 1. Bubble Sort - O(n^2)
        // -----------------------------------------
        int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("--- Bubble Sort ---");
        Console.WriteLine($"Before: [{string.Join(", ", arr1)}]");
        BubbleSort(arr1);
        Console.WriteLine($"After:  [{string.Join(", ", arr1)}]");

        // -----------------------------------------
        // 2. Insertion Sort - O(n^2)
        // -----------------------------------------
        int[] arr2 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("\n--- Insertion Sort ---");
        Console.WriteLine($"Before: [{string.Join(", ", arr2)}]");
        InsertionSort(arr2);
        Console.WriteLine($"After:  [{string.Join(", ", arr2)}]");

        // -----------------------------------------
        // 3. Merge Sort - O(n log n)
        // -----------------------------------------
        int[] arr3 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("\n--- Merge Sort ---");
        Console.WriteLine($"Before: [{string.Join(", ", arr3)}]");
        MergeSort(arr3);
        Console.WriteLine($"After:  [{string.Join(", ", arr3)}]");

        // -----------------------------------------
        // 4. Quick Sort - O(n log n) average
        // -----------------------------------------
        int[] arr4 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("\n--- Quick Sort ---");
        Console.WriteLine($"Before: [{string.Join(", ", arr4)}]");
        QuickSort(arr4);
        Console.WriteLine($"After:  [{string.Join(", ", arr4)}]");

        // -----------------------------------------
        // 5. Heap Sort - O(n log n)
        // -----------------------------------------
        int[] arr5 = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("\n--- Heap Sort ---");
        Console.WriteLine($"Before: [{string.Join(", ", arr5)}]");
        HeapSort(arr5);
        Console.WriteLine($"After:  [{string.Join(", ", arr5)}]");

        // -----------------------------------------
        // Priority Queue (Min Heap)
        // -----------------------------------------
        Console.WriteLine("\n--- Min Heap (Priority Queue) ---");
        var pq = new MinHeap();
        pq.Enqueue(10);
        pq.Enqueue(5);
        pq.Enqueue(20);
        pq.Enqueue(1);
        Console.WriteLine("Enqueued: 10, 5, 20, 1");
        Console.WriteLine($"Peek (min): {pq.Peek()}");
        Console.WriteLine($"Dequeue: {pq.Dequeue()}"); // 1
        Console.WriteLine($"Dequeue: {pq.Dequeue()}"); // 5
        Console.WriteLine($"Dequeue: {pq.Dequeue()}"); // 10
        Console.WriteLine($"Dequeue: {pq.Dequeue()}"); // 20

        // -----------------------------------------
        // Comparison Summary
        // -----------------------------------------
        Console.WriteLine("\n=== Sorting Algorithm Comparison ===");
        Console.WriteLine("Algorithm      | Best     | Average  | Worst    | Space | Stable");
        Console.WriteLine("---------------|----------|----------|----------|-------|-------");
        Console.WriteLine("Bubble Sort    | O(n)     | O(n^2)   | O(n^2)   | O(1)  | Yes");
        Console.WriteLine("Insertion Sort | O(n)     | O(n^2)   | O(n^2)   | O(1)  | Yes");
        Console.WriteLine("Merge Sort     | O(nlogn) | O(nlogn) | O(nlogn) | O(n)  | Yes");
        Console.WriteLine("Quick Sort     | O(nlogn) | O(nlogn) | O(n^2)   | O(logn)| No");
        Console.WriteLine("Heap Sort      | O(nlogn) | O(nlogn) | O(nlogn) | O(1)  | No");
    }

    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }

    public static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        MergeSort(arr, 0, arr.Length - 1);
    }

    private static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int mid = left + (right - left) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid)
            temp[k++] = arr[i++];

        while (j <= right)
            temp[k++] = arr[j++];

        Array.Copy(temp, 0, arr, left, temp.Length);
    }

    public static void QuickSort(int[] arr)
    {
        QuickSort(arr, 0, arr.Length - 1);
    }

    private static void QuickSort(int[] arr, int low, int high)
    {
        if (low >= high)
            return;

        int pivotIndex = Partition(arr, low, high);

        QuickSort(arr, low, pivotIndex - 1);
        QuickSort(arr, pivotIndex + 1, high);
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);

        return i + 1;
    }

    public static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Build max heap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // Extract elements
        for (int i = n - 1; i > 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }

    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}
