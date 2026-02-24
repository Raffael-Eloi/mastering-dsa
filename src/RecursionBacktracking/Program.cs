Console.WriteLine("=== Recursion & Backtracking ===\n");

// -----------------------------------------
// 1. Factorial (basic recursion)
// -----------------------------------------
Console.WriteLine("--- Factorial ---");
Console.WriteLine($"5! = {Factorial(5)}"); // 120
Console.WriteLine($"0! = {Factorial(0)}"); // 1

// -----------------------------------------
// 2. Fibonacci (naive recursive - O(2^n))
// -----------------------------------------
Console.WriteLine("\n--- Fibonacci (naive recursive) ---");
Console.Write("First 10: ");
for (int i = 0; i < 10; i++)
    Console.Write($"{Fibonacci(i)} ");
Console.WriteLine();
Console.WriteLine("Note: this is O(2^n) - very slow for large n. See DynamicProgramming for O(n) version.");

// -----------------------------------------
// 3. Generate all subsets (Power Set)
// -----------------------------------------
Console.WriteLine("\n--- Subsets (Power Set) ---");
var subsets = new List<List<int>>();
GenerateSubsets(new[] { 1, 2, 3 }, 0, new List<int>(), subsets);
Console.WriteLine("Subsets of [1, 2, 3]:");
foreach (var subset in subsets)
    Console.WriteLine($"  [{string.Join(", ", subset)}]");
Console.WriteLine($"Total: {subsets.Count} subsets (2^3 = 8)");

// -----------------------------------------
// 4. Generate all permutations
// -----------------------------------------
Console.WriteLine("\n--- Permutations ---");
var perms = new List<List<int>>();
GeneratePermutations(new[] { 1, 2, 3 }, 0, perms);
Console.WriteLine("Permutations of [1, 2, 3]:");
foreach (var perm in perms)
    Console.WriteLine($"  [{string.Join(", ", perm)}]");
Console.WriteLine($"Total: {perms.Count} permutations (3! = 6)");

// -----------------------------------------
// 5. N-Queens (classic backtracking)
// -----------------------------------------
Console.WriteLine("\n--- N-Queens (n=4) ---");
var solutions = new List<List<int>>();
SolveNQueens(4, new List<int>(), solutions);
Console.WriteLine($"Found {solutions.Count} solutions for 4-Queens:\n");
foreach (var solution in solutions)
{
    PrintBoard(solution);
    Console.WriteLine();
}

// =============================================
// Implementations
// =============================================

static int Factorial(int n)
{
    if (n <= 1) return 1;    // base case
    return n * Factorial(n - 1); // recursive case
}

static int Fibonacci(int n)
{
    if (n <= 1) return n;    // base cases: F(0)=0, F(1)=1
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void GenerateSubsets(int[] nums, int index, List<int> current, List<List<int>> result)
{
    // At each position, we have 2 choices: include or exclude
    if (index == nums.Length)
    {
        result.Add(new List<int>(current));
        return;
    }

    // Exclude nums[index]
    GenerateSubsets(nums, index + 1, current, result);

    // Include nums[index]
    current.Add(nums[index]);
    GenerateSubsets(nums, index + 1, current, result);
    current.RemoveAt(current.Count - 1); // backtrack
}

static void GeneratePermutations(int[] nums, int start, List<List<int>> result)
{
    if (start == nums.Length)
    {
        result.Add(new List<int>(nums));
        return;
    }

    for (int i = start; i < nums.Length; i++)
    {
        (nums[start], nums[i]) = (nums[i], nums[start]);       // swap
        GeneratePermutations(nums, start + 1, result);
        (nums[start], nums[i]) = (nums[i], nums[start]);       // backtrack (un-swap)
    }
}

static void SolveNQueens(int n, List<int> queens, List<List<int>> solutions)
{
    // queens[i] = column position of queen in row i
    if (queens.Count == n)
    {
        solutions.Add(new List<int>(queens));
        return;
    }

    int row = queens.Count;
    for (int col = 0; col < n; col++)
    {
        if (IsSafe(queens, row, col))
        {
            queens.Add(col);
            SolveNQueens(n, queens, solutions);
            queens.RemoveAt(queens.Count - 1); // backtrack
        }
    }
}

static bool IsSafe(List<int> queens, int row, int col)
{
    for (int i = 0; i < queens.Count; i++)
    {
        // Same column?
        if (queens[i] == col)
            return false;

        // Same diagonal? (row diff == col diff)
        if (Math.Abs(queens[i] - col) == Math.Abs(i - row))
            return false;
    }
    return true;
}

static void PrintBoard(List<int> queens)
{
    int n = queens.Count;
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
            Console.Write(queens[row] == col ? "Q " : ". ");
        Console.WriteLine();
    }
}
