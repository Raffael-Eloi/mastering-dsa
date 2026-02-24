# Merge Sort

## Idea

Divide and conquer: split the array in half recursively until single elements,
then merge sorted halves back together.

## Step-by-Step

```
[38, 27, 43, 3]

Split:
  [38, 27] | [43, 3]
  [38] [27] | [43] [3]

Merge:
  [27, 38] | [3, 43]
  [3, 27, 38, 43]  <- sorted!
```

## Complexity

| Case    | Time       | Why                            |
|---------|-----------|--------------------------------|
| Best    | O(n log n) | Always splits and merges       |
| Average | O(n log n) | Always splits and merges       |
| Worst   | O(n log n) | Always splits and merges       |

Space: O(n) — needs temporary array for merging.

Stable sort (preserves order of equal elements).

## Key Properties

- **Guaranteed O(n log n)** — unlike quick sort, no worst-case degradation
- **Stable** — equal elements keep their original order
- **Not in-place** — requires O(n) extra space for merging
- **Parallelizable** — left and right halves can be sorted independently

## When to Use

- Need guaranteed O(n log n) performance
- Stability matters (preserving order of equal elements)
- Sorting linked lists (merge sort is optimal for linked lists — no random access needed)
- External sorting (sorting data that doesn't fit in memory)
