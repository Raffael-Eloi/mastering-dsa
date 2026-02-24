Console.WriteLine("=== Greedy Algorithms ===\n");

// -----------------------------------------
// 1. Activity Selection (Interval Scheduling)
// -----------------------------------------
Console.WriteLine("--- Activity Selection ---");
Console.WriteLine("Select maximum non-overlapping activities.");
int[] start = { 1, 3, 0, 5, 8, 5 };
int[] end =   { 2, 4, 6, 7, 9, 9 };

Console.WriteLine("Activities (start, end):");
for (int i = 0; i < start.Length; i++)
    Console.WriteLine($"  Activity {i}: [{start[i]}, {end[i]})");

var selected = ActivitySelection(start, end);
Console.WriteLine($"\nSelected: [{string.Join(", ", selected)}]");
Console.WriteLine($"Maximum non-overlapping: {selected.Count}");

// -----------------------------------------
// 2. Fractional Knapsack
// -----------------------------------------
Console.WriteLine("\n--- Fractional Knapsack ---");
int[] weights = { 10, 20, 30 };
int[] values =  { 60, 100, 120 };
int capacity = 50;

Console.WriteLine($"Items (weight, value, ratio):");
for (int i = 0; i < weights.Length; i++)
    Console.WriteLine($"  Item {i}: weight={weights[i]}, value={values[i]}, ratio={values[i] / (double)weights[i]:F1}");

Console.WriteLine($"Capacity: {capacity}");
double maxValue = FractionalKnapsack(weights, values, capacity);
Console.WriteLine($"Max value: {maxValue}"); // 240 (take all of item 0 & 1, 2/3 of item 2)

// -----------------------------------------
// 3. Jump Game
// -----------------------------------------
Console.WriteLine("\n--- Jump Game ---");
int[] jumps1 = { 2, 3, 1, 1, 4 };
int[] jumps2 = { 3, 2, 1, 0, 4 };

Console.WriteLine($"[{string.Join(", ", jumps1)}] -> can reach end: {CanJump(jumps1)}"); // True
Console.WriteLine($"[{string.Join(", ", jumps2)}] -> can reach end: {CanJump(jumps2)}"); // False

// =============================================
// Implementations
// =============================================

// Activity Selection: pick the activity that finishes earliest (greedy choice)
// Time: O(n log n) for sorting
static List<int> ActivitySelection(int[] start, int[] end)
{
    int n = start.Length;

    // Create indices sorted by end time
    int[] indices = Enumerable.Range(0, n).ToArray();
    Array.Sort(indices, (a, b) => end[a].CompareTo(end[b]));

    var selected = new List<int>();
    selected.Add(indices[0]); // always pick the first (earliest finish)
    int lastEnd = end[indices[0]];

    for (int i = 1; i < n; i++)
    {
        int idx = indices[i];
        if (start[idx] >= lastEnd) // doesn't overlap
        {
            selected.Add(idx);
            lastEnd = end[idx];
        }
    }

    return selected;
}

// Fractional Knapsack: take items by highest value/weight ratio
// Unlike 0/1 Knapsack, we can take fractions of items
// Time: O(n log n)
static double FractionalKnapsack(int[] weights, int[] values, int capacity)
{
    int n = weights.Length;

    // Sort by value/weight ratio (descending)
    int[] indices = Enumerable.Range(0, n).ToArray();
    Array.Sort(indices, (a, b) =>
        (values[b] / (double)weights[b]).CompareTo(values[a] / (double)weights[a]));

    double totalValue = 0;
    int remaining = capacity;

    foreach (int i in indices)
    {
        if (remaining == 0) break;

        if (weights[i] <= remaining)
        {
            // Take the whole item
            totalValue += values[i];
            remaining -= weights[i];
        }
        else
        {
            // Take a fraction
            totalValue += values[i] * (remaining / (double)weights[i]);
            remaining = 0;
        }
    }

    return totalValue;
}

// Jump Game: can you reach the last index?
// Greedy: track the farthest reachable position
// Time: O(n), Space: O(1)
static bool CanJump(int[] nums)
{
    int farthest = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (i > farthest)
            return false; // can't reach this position

        farthest = Math.Max(farthest, i + nums[i]);

        if (farthest >= nums.Length - 1)
            return true;
    }

    return true;
}
