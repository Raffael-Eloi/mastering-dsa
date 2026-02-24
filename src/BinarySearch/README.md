# Binary Search

Binary search finds an element in a **sorted** array by repeatedly halving the search space.

Instead of checking every element O(n), it cuts the array in half each step: **O(log n)**.

## How It Works

```
Array: [1, 3, 5, 7, 9, 11, 13]
Target: 9

Step 1: mid=3, arr[3]=7  -> 9 > 7 -> search right half
Step 2: mid=5, arr[5]=11 -> 9 < 11 -> search left half
Step 3: mid=4, arr[4]=9  -> Found!
```

3 steps to find element in 7-element array (instead of up to 7 with linear search).

## Two Implementations

| Approach   | Time     | Space     | Notes                         |
|-----------|----------|-----------|-------------------------------|
| Iterative | O(log n) | O(1)      | Uses a while loop             |
| Recursive | O(log n) | O(log n)  | Call stack adds space overhead |

### Key formula to avoid overflow:

```csharp
int mid = left + (right - left) / 2;  // safe
// instead of:
int mid = (left + right) / 2;         // can overflow for large values
```

## Why O(log n)

Each step halves the search space:

```
n -> n/2 -> n/4 -> n/8 -> ... -> 1
```

How many times can you divide n by 2 until you reach 1? That's log2(n).

For 1,000,000 elements: only ~20 comparisons needed.

## Prerequisite

Binary search **requires sorted data**. If the data isn't sorted,
you must sort it first (O(n log n)) or use linear search.

## When to Use

- Searching in sorted arrays
- Finding boundaries (first/last occurrence)
- Optimization problems ("what's the minimum X such that...")
- Any problem where you can discard half the search space
