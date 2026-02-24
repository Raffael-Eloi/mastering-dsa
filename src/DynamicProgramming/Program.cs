Console.WriteLine("=== Dynamic Programming ===\n");

// -----------------------------------------
// 1. Fibonacci - Memoization (Top-Down) vs Tabulation (Bottom-Up)
// -----------------------------------------
Console.WriteLine("--- Fibonacci ---");
Console.WriteLine($"Naive recursive F(10):    {FibNaive(10)}");
Console.WriteLine($"Memoized (top-down) F(10): {FibMemo(10, new Dictionary<int, long>())}");
Console.WriteLine($"Tabulated (bottom-up) F(10): {FibTab(10)}");
Console.WriteLine($"Tabulated F(50): {FibTab(50)}");
Console.WriteLine("(Naive would take forever for F(50) -- O(2^n) vs O(n))");

// -----------------------------------------
// 2. Climbing Stairs
// -----------------------------------------
Console.WriteLine("\n--- Climbing Stairs ---");
Console.WriteLine("How many ways to climb n stairs (1 or 2 steps at a time)?");
Console.WriteLine($"n=3: {ClimbStairs(3)} ways");   // 3: (1+1+1, 1+2, 2+1)
Console.WriteLine($"n=5: {ClimbStairs(5)} ways");   // 8
Console.WriteLine($"n=10: {ClimbStairs(10)} ways"); // 89

// -----------------------------------------
// 3. Coin Change (minimum coins)
// -----------------------------------------
Console.WriteLine("\n--- Coin Change ---");
int[] coins = { 1, 5, 10, 25 };
Console.WriteLine($"Coins: [{string.Join(", ", coins)}]");
Console.WriteLine($"Min coins for 30: {CoinChange(coins, 30)}"); // 2 (25+5)
Console.WriteLine($"Min coins for 11: {CoinChange(coins, 11)}"); // 2 (10+1)
Console.WriteLine($"Min coins for 3:  {CoinChange(coins, 3)}");  // 3 (1+1+1)

int result = CoinChange(new[] { 2 }, 3);
Console.WriteLine($"Min coins for 3 with [2]: {(result == -1 ? "impossible" : result)}"); // impossible

// -----------------------------------------
// 4. Longest Common Subsequence (LCS)
// -----------------------------------------
Console.WriteLine("\n--- Longest Common Subsequence ---");
Console.WriteLine($"LCS('ABCBDAB', 'BDCAB'): {LCS("ABCBDAB", "BDCAB")}"); // 4 (BCAB)
Console.WriteLine($"LCS('ABC', 'DEF'):       {LCS("ABC", "DEF")}");       // 0
Console.WriteLine($"LCS('ABC', 'ABC'):       {LCS("ABC", "ABC")}");       // 3

// -----------------------------------------
// 5. 0/1 Knapsack
// -----------------------------------------
Console.WriteLine("\n--- 0/1 Knapsack ---");
int[] weights = { 1, 3, 4, 5 };
int[] values = { 1, 4, 5, 7 };
int capacity = 7;
Console.WriteLine($"Weights: [{string.Join(", ", weights)}]");
Console.WriteLine($"Values:  [{string.Join(", ", values)}]");
Console.WriteLine($"Capacity: {capacity}");
Console.WriteLine($"Max value: {Knapsack(weights, values, capacity)}"); // 9 (items 1+3 -> w=3+4=7? no. items w=3,4 -> v=4+5=9)

// =============================================
// Implementations
// =============================================

// Fibonacci - Naive O(2^n)
static long FibNaive(int n)
{
    if (n <= 1) return n;
    return FibNaive(n - 1) + FibNaive(n - 2);
}

// Fibonacci - Memoization (Top-Down) O(n)
// Store results of subproblems to avoid recomputation
static long FibMemo(int n, Dictionary<int, long> memo)
{
    if (n <= 1) return n;
    if (memo.ContainsKey(n)) return memo[n];

    memo[n] = FibMemo(n - 1, memo) + FibMemo(n - 2, memo);
    return memo[n];
}

// Fibonacci - Tabulation (Bottom-Up) O(n)
// Build up from smallest subproblems
static long FibTab(int n)
{
    if (n <= 1) return n;

    long prev2 = 0, prev1 = 1;
    for (int i = 2; i <= n; i++)
    {
        long current = prev1 + prev2;
        prev2 = prev1;
        prev1 = current;
    }
    return prev1;
}

// Climbing Stairs: ways(n) = ways(n-1) + ways(n-2)
// Same recurrence as Fibonacci!
static int ClimbStairs(int n)
{
    if (n <= 2) return n;

    int prev2 = 1, prev1 = 2;
    for (int i = 3; i <= n; i++)
    {
        int current = prev1 + prev2;
        prev2 = prev1;
        prev1 = current;
    }
    return prev1;
}

// Coin Change: minimum coins to make amount
// dp[i] = min coins needed to make amount i
static int CoinChange(int[] coins, int amount)
{
    int[] dp = new int[amount + 1];
    Array.Fill(dp, amount + 1); // fill with "impossible" value
    dp[0] = 0;

    for (int i = 1; i <= amount; i++)
    {
        foreach (int coin in coins)
        {
            if (coin <= i && dp[i - coin] + 1 < dp[i])
                dp[i] = dp[i - coin] + 1;
        }
    }

    return dp[amount] > amount ? -1 : dp[amount];
}

// Longest Common Subsequence
// dp[i][j] = LCS length of first i chars of s1 and first j chars of s2
static int LCS(string s1, string s2)
{
    int m = s1.Length, n = s2.Length;
    int[,] dp = new int[m + 1, n + 1];

    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (s1[i - 1] == s2[j - 1])
                dp[i, j] = dp[i - 1, j - 1] + 1;
            else
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
        }
    }

    return dp[m, n];
}

// 0/1 Knapsack
// dp[i][w] = max value using first i items with capacity w
static int Knapsack(int[] weights, int[] values, int capacity)
{
    int n = weights.Length;
    int[,] dp = new int[n + 1, capacity + 1];

    for (int i = 1; i <= n; i++)
    {
        for (int w = 0; w <= capacity; w++)
        {
            // Don't take item i
            dp[i, w] = dp[i - 1, w];

            // Take item i (if it fits)
            if (weights[i - 1] <= w)
            {
                int withItem = dp[i - 1, w - weights[i - 1]] + values[i - 1];
                dp[i, w] = Math.Max(dp[i, w], withItem);
            }
        }
    }

    return dp[n, capacity];
}
