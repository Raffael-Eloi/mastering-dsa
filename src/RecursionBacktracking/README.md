# Recursion & Backtracking

## Recursion

A function that calls itself to solve smaller sub-problems until reaching a **base case**.

### Anatomy of a Recursive Function

```
function solve(problem):
    if (base case):       <- stop condition
        return result
    return solve(smaller problem)  <- recursive call
```

### Call Stack Visualization

```
Factorial(4)
  -> 4 * Factorial(3)
    -> 3 * Factorial(2)
      -> 2 * Factorial(1)
        -> returns 1       <- base case
      -> returns 2 * 1 = 2
    -> returns 3 * 2 = 6
  -> returns 4 * 6 = 24
```

Each recursive call adds a frame to the call stack. Stack depth = O(n).

## Backtracking

Backtracking builds solutions incrementally and **abandons** a path as soon as it
determines it cannot lead to a valid solution.

### Backtracking Template

```
function backtrack(state):
    if (state is a solution):
        record solution
        return

    for each choice:
        if (choice is valid):
            make choice           <- choose
            backtrack(new state)  <- explore
            undo choice           <- un-choose (backtrack)
```

## Examples in This Project

| Problem       | Type          | Time         | Key Insight                        |
|--------------|---------------|--------------|------------------------------------|
| Factorial    | Basic recursion| O(n)         | Multiply n by result of (n-1)      |
| Fibonacci    | Basic recursion| O(2^n)       | Overlapping subproblems (see DP)   |
| Subsets      | Backtracking  | O(2^n)       | Each element: include or exclude   |
| Permutations | Backtracking  | O(n!)        | Swap each element to each position |
| N-Queens     | Backtracking  | O(n!)        | Place queens row by row, prune conflicts |

## Recursion vs Iteration

| Recursion               | Iteration              |
|------------------------|------------------------|
| More elegant code      | More efficient         |
| Uses call stack (O(n)) | Uses O(1) space        |
| Risk of stack overflow | No stack overflow risk |
| Natural for trees/graphs| Natural for arrays    |

## When Recursion Leads to DP

If your recursive solution solves the **same subproblem multiple times** (overlapping
subproblems), you can optimize it with memoization or tabulation. Fibonacci is the
classic example: naive recursion is O(2^n), DP reduces it to O(n).
