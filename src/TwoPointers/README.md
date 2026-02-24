# Two Pointers & Sliding Window

These are technique patterns (not data structures) that optimize brute-force solutions
from O(n^2) down to O(n) by using smart pointer movement.

## Pattern 1: Converging Two Pointers

Two pointers start at opposite ends and move toward each other.

```
[1, 3, 5, 7, 9, 11]
 ^                ^
left            right
```

**When to use**: sorted arrays, pair-finding, palindrome checking.

**Examples**: Two Sum (sorted), Container With Most Water, Valid Palindrome.

## Pattern 2: Fast/Slow Pointers

One pointer moves faster than the other.

```
[1, 1, 2, 2, 3, 4, 4, 5]
 s
    f
```

**When to use**: removing duplicates in-place, cycle detection (linked list),
finding middle of linked list.

## Pattern 3: Sliding Window

Maintain a window [left, right] that expands and contracts.

```
"a b c a b c b b"
 [---]               window = "abc", len=3
   [---]             window = "bca", len=3
     [-----]         window = "cab", len=3 (expand until duplicate)
       [-]           shrink when duplicate found
```

**When to use**: substrings, subarrays, contiguous sequences with a constraint.

**Examples**: Longest substring without repeating chars, maximum sum subarray of size k.

## Complexity

| Problem                          | Brute Force | Two Pointers |
|---------------------------------|-------------|--------------|
| Two Sum (sorted)                | O(n^2)      | O(n)         |
| Container With Most Water       | O(n^2)      | O(n)         |
| Remove Duplicates               | O(n^2)*     | O(n)         |
| Longest Substring No Repeats    | O(n^2)      | O(n)         |

*With shifting elements.

## How to Recognize

Ask yourself:
- Is the input sorted or can be sorted? -> **converging pointers**
- Am I looking for a pair or triplet? -> **two/three pointers**
- Am I looking at subarrays/substrings? -> **sliding window**
- Do I need to modify an array in-place? -> **fast/slow pointers**
