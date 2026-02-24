# Heap Sort

## Idea

Use a max heap (binary heap) to sort:
1. Build a max heap from the array
2. Repeatedly extract the maximum and place it at the end

## Step-by-Step

```
Array: [64, 34, 25, 12, 22, 11, 90]

Step 1: Build max heap
  [90, 34, 64, 12, 22, 11, 25]

Step 2: Extract max (90), swap with last, heapify
  [64, 34, 25, 12, 22, 11] | 90

Step 3: Extract max (64), swap with last, heapify
  [34, 22, 25, 12, 11] | 64, 90

... continue until sorted:
  [11, 12, 22, 25, 34, 64, 90]
```

## Complexity

| Case    | Time       | Why                              |
|---------|-----------|----------------------------------|
| Best    | O(n log n) | Must build heap and extract all  |
| Average | O(n log n) | Heapify is O(log n), done n times|
| Worst   | O(n log n) | No degradation unlike quick sort |

Space: O(1) — in-place (no extra array needed).

Not stable (heap operations can reorder equal elements).

## Key Concepts

- **Max Heap**: parent >= both children
- **Heapify**: restore heap property by "sinking" a node down
- **Build Heap**: start from last non-leaf, heapify each — O(n) total

## When to Use

- Need guaranteed O(n log n) with O(1) space
- Memory is constrained (unlike merge sort which needs O(n) extra space)
- Don't need stability
