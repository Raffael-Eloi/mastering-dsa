// ===========================================
// Big O Notation - Time & Space Complexity
// ===========================================
// This project demonstrates how different algorithms
// scale as input size grows.

Console.WriteLine("=== Big O Notation Examples ===\n");

// -----------------------------------------
// O(1) - Constant Time
// -----------------------------------------
// No matter how large the input, it takes the same time.
Console.WriteLine("--- O(1) Constant Time ---");
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine($"First element: {numbers[0]}");
Console.WriteLine($"Last element: {numbers[^1]}");
Console.WriteLine("Array access is always O(1) regardless of size.\n");

// -----------------------------------------
// O(n) - Linear Time
// -----------------------------------------
// Time grows proportionally with input size.
Console.WriteLine("--- O(n) Linear Time ---");
int sum = 0;
int operations = 0;
foreach (int num in numbers)
{
    sum += num;
    operations++;
}
Console.WriteLine($"Sum of {numbers.Length} elements: {sum}");
Console.WriteLine($"Operations: {operations} (same as array length)\n");

// -----------------------------------------
// O(n^2) - Quadratic Time
// -----------------------------------------
// Nested loops: for each element, we visit every other element.
Console.WriteLine("--- O(n^2) Quadratic Time ---");
int[] small = { 1, 2, 3, 4 };
int pairCount = 0;
for (int i = 0; i < small.Length; i++)
{
    for (int j = i + 1; j < small.Length; j++)
    {
        Console.WriteLine($"  Pair: ({small[i]}, {small[j]})");
        pairCount++;
    }
}
Console.WriteLine($"Total pairs from {small.Length} elements: {pairCount}");
Console.WriteLine("With n elements, pairs grow as n*(n-1)/2 which is O(n^2).\n");

// -----------------------------------------
// O(log n) - Logarithmic Time
// -----------------------------------------
// Each step cuts the problem in half (e.g. binary search).
Console.WriteLine("--- O(log n) Logarithmic Time ---");
int n = 64;
int steps = 0;
int value = n;
Console.Write($"Halving {n}: ");
while (value > 1)
{
    Console.Write($"{value} -> ");
    value /= 2;
    steps++;
}
Console.WriteLine($"{value}");
Console.WriteLine($"Steps to reduce {n} to 1: {steps} (log2({n}) = {steps})\n");

// -----------------------------------------
// O(n log n) - Linearithmic Time
// -----------------------------------------
// Common in efficient sorting algorithms (merge sort, quick sort).
Console.WriteLine("--- O(n log n) Linearithmic Time ---");
int[] unsorted = { 38, 27, 43, 3, 9, 82, 10 };
Console.WriteLine($"Unsorted: [{string.Join(", ", unsorted)}]");
Array.Sort(unsorted); // uses O(n log n) sorting internally
Console.WriteLine($"Sorted:   [{string.Join(", ", unsorted)}]");
Console.WriteLine("Efficient sorting is O(n log n) — much better than O(n^2) for large inputs.\n");

// -----------------------------------------
// Comparison Summary
// -----------------------------------------
Console.WriteLine("=== Growth Comparison (n = 1000) ===");
Console.WriteLine("O(1)       ->          1 operation");
Console.WriteLine("O(log n)   ->         10 operations");
Console.WriteLine("O(n)       ->      1,000 operations");
Console.WriteLine("O(n log n) ->     10,000 operations");
Console.WriteLine("O(n^2)     ->  1,000,000 operations");
Console.WriteLine();
Console.WriteLine("Key takeaway: as n grows, the difference between");
Console.WriteLine("O(n) and O(n^2) becomes massive. Choosing the right");
Console.WriteLine("algorithm matters!");
