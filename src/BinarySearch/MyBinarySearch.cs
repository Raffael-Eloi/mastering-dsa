namespace BinarySearch;

public class MyBinarySearch
{
    // Iterative: Time O(log n), Space O(1)
    public static int Search(int[] arr, int target)
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

    // Recursive: Time O(log n), Space O(log n) due to call stack
    public static int SearchRecursive(int[] arr, int target, int left, int right)
    {
        if (left > right)
            return -1;

        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid;

        if (arr[mid] < target)
            return SearchRecursive(arr, target, mid + 1, right);

        return SearchRecursive(arr, target, left, mid - 1);
    }
}
