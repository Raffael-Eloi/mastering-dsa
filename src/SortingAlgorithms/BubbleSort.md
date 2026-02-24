# Bubble Sort

## Idea

Repeatedly swap adjacent elements if they're out of order.
The largest element "bubbles" to the end each pass.

## Step-by-Step

```
[64, 34, 25, 12]

Pass 1: Compare adjacent pairs, swap if needed
  64 > 34 -> swap -> [34, 64, 25, 12]
  64 > 25 -> swap -> [34, 25, 64, 12]
  64 > 12 -> swap -> [34, 25, 12, 64]  <- 64 is now in place

Pass 2:
  34 > 25 -> swap -> [25, 34, 12, 64]
  34 > 12 -> swap -> [25, 12, 34, 64]  <- 34 is now in place

Pass 3:
  25 > 12 -> swap -> [12, 25, 34, 64]  <- sorted!
```

## Complexity

| Case    | Time   | Why                                      |
|---------|--------|------------------------------------------|
| Best    | O(n)   | Already sorted, no swaps (with flag)     |
| Average | O(n^2) | Nested loops                             |
| Worst   | O(n^2) | Reverse sorted                           |

Space: O(1) — in-place, stable sort.

## Optimization

The `swapped` flag lets us exit early if no swaps occur in a pass,
making the best case O(n) for already-sorted arrays.

## When to Use

- Educational purposes (simplest sorting algorithm to understand)
- Very small datasets
- Nearly sorted data (with the optimization flag)
