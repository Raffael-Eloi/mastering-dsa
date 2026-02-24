using BinarySearch;

Console.WriteLine("=== Binary Search ===\n");

int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
Console.WriteLine($"Array: [{string.Join(", ", arr)}]\n");

// -----------------------------------------
// Iterative Binary Search - O(log n) time, O(1) space
// -----------------------------------------
Console.WriteLine("--- Iterative ---");
int index1 = MyBinarySearch.Search(arr, 7);
Console.WriteLine($"Search for 7:  found at index {index1}");

int index2 = MyBinarySearch.Search(arr, 19);
Console.WriteLine($"Search for 19: found at index {index2}");

int index3 = MyBinarySearch.Search(arr, 8);
Console.WriteLine($"Search for 8:  {(index3 == -1 ? "not found" : $"index {index3}")}");

// -----------------------------------------
// Recursive Binary Search - O(log n) time, O(log n) space
// -----------------------------------------
Console.WriteLine("\n--- Recursive ---");
int index4 = MyBinarySearch.SearchRecursive(arr, 13, 0, arr.Length - 1);
Console.WriteLine($"Search for 13: found at index {index4}");

int index5 = MyBinarySearch.SearchRecursive(arr, 1, 0, arr.Length - 1);
Console.WriteLine($"Search for 1:  found at index {index5}");

int index6 = MyBinarySearch.SearchRecursive(arr, 20, 0, arr.Length - 1);
Console.WriteLine($"Search for 20: {(index6 == -1 ? "not found" : $"index {index6}")}");

// -----------------------------------------
// Step-by-step visualization
// -----------------------------------------
Console.WriteLine("\n--- Step-by-Step: searching for 13 ---");
int left = 0, right = arr.Length - 1;
int step = 1;
while (left <= right)
{
    int mid = left + (right - left) / 2;
    Console.WriteLine($"Step {step}: left={left}, right={right}, mid={mid}, arr[mid]={arr[mid]}");
    if (arr[mid] == 13) { Console.WriteLine($"  Found 13 at index {mid}!"); break; }
    if (arr[mid] < 13) { Console.WriteLine("  13 > arr[mid] -> search right half"); left = mid + 1; }
    else { Console.WriteLine("  13 < arr[mid] -> search left half"); right = mid - 1; }
    step++;
}
