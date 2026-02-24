# Linked List

A linked list is a linear data structure where elements (nodes) are stored in scattered memory locations,
connected by pointers. Unlike arrays, elements are not stored contiguously.

## Array vs Linked List

| Feature          | Array              | Linked List          |
|-----------------|--------------------|----------------------|
| Memory layout   | Contiguous         | Scattered + pointers |
| Access by index | O(1)               | O(n)                 |
| Insert at start | O(n) (shift all)   | O(1)                 |
| Insert at end   | O(1) (amortized)   | O(n) without tail    |
| Delete at start | O(n) (shift all)   | O(1)                 |
| Size            | Fixed or resized   | Dynamic              |

## Node Structure

Each node holds a value and a pointer to the next node:

```
[Data | Next] -> [Data | Next] -> [Data | Next] -> null
```

## Operations Complexity

| Operation    | Time   | Why                              |
|-------------|--------|----------------------------------|
| AddFirst    | O(1)   | Just update head pointer         |
| AddLast     | O(n)   | Must traverse to find the end    |
| RemoveFirst | O(1)   | Just move head to next           |
| RemoveLast  | O(n)   | Must find second-to-last node    |
| Contains    | O(n)   | Must traverse and compare        |
| Count       | O(n)   | Must traverse entire list        |

## When to Use

- Frequent insertions/deletions at the beginning
- Unknown size at compile time
- No need for random access by index

## When NOT to Use

- Need fast access by index (use an array)
- Memory is a concern (each node has pointer overhead)
- Cache performance matters (arrays are cache-friendly due to contiguous memory)
