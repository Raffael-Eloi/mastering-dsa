# Big O Notation

Big O describes how an algorithm's time or space requirements grow as the input size (n) increases.
It focuses on the **worst-case** growth rate, ignoring constants and lower-order terms.

## Time Complexity

| Notation     | Name           | Example                          |
|-------------|----------------|----------------------------------|
| O(1)        | Constant       | Array access by index            |
| O(log n)    | Logarithmic    | Binary search                    |
| O(n)        | Linear         | Loop through array               |
| O(n log n)  | Linearithmic   | Merge sort, Quick sort (avg)     |
| O(n^2)      | Quadratic      | Nested loops, Bubble sort        |
| O(2^n)      | Exponential    | Recursive Fibonacci (naive)      |

## Space Complexity

Space complexity measures the **extra memory** an algorithm needs beyond the input.

| Example                        | Space     |
|-------------------------------|-----------|
| Single variable               | O(1)      |
| Copy of array                 | O(n)      |
| Recursive call stack (binary) | O(log n)  |
| 2D matrix                     | O(n^2)    |

## How to Analyze

1. **Drop constants**: O(2n) becomes O(n)
2. **Keep the dominant term**: O(n^2 + n) becomes O(n^2)
3. **Nested loops multiply**: a loop inside a loop over n is O(n * n) = O(n^2)
4. **Sequential steps add**: two separate loops over n is O(n + n) = O(n)

## Why It Matters

For n = 1,000:
- O(n) = 1,000 operations
- O(n^2) = 1,000,000 operations

Choosing an O(n log n) sort over an O(n^2) sort can mean the difference between
milliseconds and minutes on large datasets.
