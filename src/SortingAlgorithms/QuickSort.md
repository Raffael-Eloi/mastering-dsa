# Quick Sort

## Idea

Pick a pivot element. Partition the array so that:
- Elements smaller than pivot go left
- Elements larger than pivot go right
Then recursively sort both partitions.

## Step-by-Step

```
[64, 34, 25, 12, 22, 11, 90]   pivot=90

Partition: everything < 90 goes left
[64, 34, 25, 12, 22, 11] | 90

Next: pivot=11
[11] | [34, 25, 12, 22, 64]

Continue recursively until sorted...
Result: [11, 12, 22, 25, 34, 64, 90]
```

## Complexity

| Case    | Time       | Why                                    |
|---------|-----------|----------------------------------------|
| Best    | O(n log n) | Pivot splits evenly                    |
| Average | O(n log n) | Random pivots tend to split well       |
| Worst   | O(n^2)     | Pivot is always min or max (sorted input)|

Space: O(log n) — recursion stack depth.

Not stable (partitioning can reorder equal elements).

## Pivot Choice Matters

- **Last element** (our implementation): simple but worst case on sorted input
- **Random**: avoids worst case in practice
- **Median-of-three**: pick median of first, middle, last elements

## When to Use

- General-purpose sorting (fast average case, low overhead)
- In-place sorting needed (O(log n) space vs O(n) for merge sort)
- Arrays (not ideal for linked lists — needs random access for partitioning)

## Quick Sort vs Merge Sort

| Feature          | Quick Sort        | Merge Sort        |
|-----------------|-------------------|-------------------|
| Average time    | O(n log n)        | O(n log n)        |
| Worst time      | O(n^2)            | O(n log n)        |
| Space           | O(log n)          | O(n)              |
| Stable          | No                | Yes               |
| In practice     | Usually faster    | More predictable  |
