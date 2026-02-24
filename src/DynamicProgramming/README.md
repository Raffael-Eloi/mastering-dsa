# Dynamic Programming (DP)

Dynamic Programming optimizes recursive solutions that have **overlapping subproblems**
by storing results so each subproblem is solved only once.

## When to Use DP

A problem is a DP candidate if it has:

1. **Overlapping subproblems**: the same sub-problem is solved multiple times
2. **Optimal substructure**: the optimal solution contains optimal solutions to sub-problems

## Two Approaches

### Memoization (Top-Down)

Start with the original problem, recurse, and cache results.

```
fib(5) -> fib(4) + fib(3)
           fib(4) -> fib(3) + fib(2)  <- fib(3) already cached!
```

### Tabulation (Bottom-Up)

Build a table from the smallest subproblems up to the answer.

```
dp[0] = 0, dp[1] = 1
dp[2] = dp[1] + dp[0] = 1
dp[3] = dp[2] + dp[1] = 2
dp[4] = dp[3] + dp[2] = 3
dp[5] = dp[4] + dp[3] = 5
```

| Feature        | Memoization       | Tabulation        |
|---------------|-------------------|-------------------|
| Direction     | Top-down          | Bottom-up         |
| Implementation| Recursion + cache | Iteration + array |
| Solves        | Only needed states| All states        |
| Stack overflow| Possible (deep recursion)| No         |

## Problems in This Project

| Problem             | Recurrence                          | Time    | Space  |
|--------------------|-------------------------------------|---------|--------|
| Fibonacci          | F(n) = F(n-1) + F(n-2)             | O(n)    | O(1)*  |
| Climbing Stairs    | ways(n) = ways(n-1) + ways(n-2)    | O(n)    | O(1)*  |
| Coin Change        | dp[i] = min(dp[i-coin] + 1)        | O(n*m)  | O(n)   |
| LCS                | dp[i][j] depends on match/no-match | O(m*n)  | O(m*n) |
| 0/1 Knapsack       | take or skip each item              | O(n*W)  | O(n*W) |

*O(1) when using space-optimized version (only keeping previous two values).

## How to Approach a DP Problem

1. **Can I solve it recursively?** Write the brute force recursive solution first
2. **Are there overlapping subproblems?** Draw the recursion tree -- do branches repeat?
3. **Define the state**: what variables uniquely identify a subproblem?
4. **Write the recurrence**: how does the current state relate to smaller states?
5. **Add memoization** or **convert to tabulation**
6. **Optimize space** if possible (do you need the full table or just the last row?)

## Naive Recursion vs DP

```
Fibonacci(40):
  Naive recursion: ~1 billion calls  (O(2^n))
  DP:              40 computations   (O(n))
```

This difference is the entire point of DP.
