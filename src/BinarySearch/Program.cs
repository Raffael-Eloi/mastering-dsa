//📊 Complexity

//Time → O(log n)
//Space → O(1)
using System.Timers;

static int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid;

        if (arr[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1;
}

static int BinarySearchRecursive(int[] arr, int target, int left, int right)
{
    if (left > right)
        return -1;

    int mid = left + (right - left) / 2;

    if (arr[mid] == target)
        return mid;

    if (arr[mid] < target)
        return BinarySearchRecursive(arr, target, mid + 1, right);

    return BinarySearchRecursive(arr, target, left, mid - 1);
}

//Time → O(log n)
//Space → O(log n) (call stack)