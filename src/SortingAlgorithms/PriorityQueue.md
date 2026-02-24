# Priority Queue (Min Heap)

## What Is a Priority Queue?

A data structure where elements are removed based on **priority**, not insertion order.
Usually implemented with a binary heap.

- **Min Heap**: smallest element always at the root (index 0)
- **Max Heap**: largest element always at the root

## Heap Structure (Array Representation)

A heap is a **complete binary tree** stored as an array:

```
Index:  0  1  2  3  4  5  6
Value: [1, 3, 5, 7, 9, 6, 8]

Tree form:
        1
       / \
      3   5
     / \ / \
    7  9 6  8
```

## Index Relationships (memorize these)

```
Parent(i)     = (i - 1) / 2
LeftChild(i)  = 2 * i + 1
RightChild(i) = 2 * i + 2
```

## Operations

| Operation | Time     | How                              |
|-----------|----------|----------------------------------|
| Enqueue   | O(log n) | Add at end, bubble up            |
| Dequeue   | O(log n) | Remove root, replace with last, heapify down |
| Peek      | O(1)     | Return root                      |

## Bubble Up (after insert)

New element is added at the end. Compare with parent and swap if smaller (min heap).
Repeat until heap property is restored.

## Heapify Down (after remove)

Root is replaced with last element. Compare with children and swap with the smallest.
Repeat until heap property is restored.

## When to Use

- Dijkstra's shortest path algorithm
- Task scheduling (process highest-priority task first)
- Median finding (two heaps)
- K-th largest/smallest element problems
