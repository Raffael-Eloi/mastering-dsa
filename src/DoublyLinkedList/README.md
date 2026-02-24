# Doubly Linked List

A doubly linked list is like a singly linked list, but each node has **two pointers**:
one to the next node and one to the previous node.

```
null <- [5] <-> [10] <-> [20] <-> [30] -> null
        head                       tail
```

## Singly vs Doubly Linked List

| Operation    | Singly  | Doubly  | Why doubly is better                  |
|-------------|---------|---------|---------------------------------------|
| AddFirst    | O(1)    | O(1)    | Same                                  |
| AddLast     | O(n)*   | O(1)    | Doubly tracks tail pointer            |
| RemoveFirst | O(1)    | O(1)    | Same                                  |
| RemoveLast  | O(n)    | O(1)    | Doubly can go back from tail          |
| Contains    | O(n)    | O(n)    | Same (must traverse)                  |
| Reverse     | O(n)    | O(1)**  | Doubly can start from tail            |

*O(1) if singly linked list also tracks tail, but removal still requires previous node.
**Starting traversal from tail is O(1), full reverse traversal is O(n).

## Key Advantage

The biggest win is **O(1) RemoveLast**. In a singly linked list, removing the last
element requires traversing to the second-to-last node (O(n)). With a `Previous`
pointer, you simply go `tail.Previous`.

## Trade-offs

- **More memory**: each node stores an extra pointer (Previous)
- **More complex code**: insertions and deletions must update both Next and Previous
- **Better for**: LRU caches, browser history (back/forward), undo/redo

## When to Use

- Need efficient insertion/removal at **both** ends (deque)
- Need to traverse in **both directions**
- Implementing LRU cache (doubly linked list + hash map)
- Browser navigation (back and forward buttons)
