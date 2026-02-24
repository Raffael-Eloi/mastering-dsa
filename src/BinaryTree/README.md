# Binary Tree

A binary tree is a tree where each node has **at most 2 children** (left and right).
Unlike a BST, there is **no ordering rule** — values can be anywhere.

```
        1
      /   \
     2     3
    / \     \
   4   5     6
```

## Key Terms

- **Root**: top node (1)
- **Leaf**: node with no children (4, 5, 6)
- **Height**: longest path from root to a leaf
- **Complete tree**: every level is fully filled except possibly the last

## Four Traversal Types

| Traversal   | Order               | Result (above tree) | Use Case                    |
|-------------|---------------------|---------------------|-----------------------------|
| In-Order    | Left, Root, Right   | 4 2 5 1 6 3        | Sorted output (for BST)     |
| Pre-Order   | Root, Left, Right   | 1 2 4 5 3 6        | Copy/serialize a tree       |
| Post-Order  | Left, Right, Root   | 4 5 2 6 3 1        | Delete tree / evaluate expr |
| Level-Order | Level by level (BFS)| 1 2 3 4 5 6        | BFS, shortest path          |

## Complexity

| Operation     | Time   | Space  |
|---------------|--------|--------|
| Insert (BFS)  | O(n)   | O(n)   |
| Traversal     | O(n)   | O(h)*  |
| Height        | O(n)   | O(h)*  |
| Count         | O(n)   | O(h)*  |

*h = height of tree. For balanced trees h = log(n), worst case h = n (skewed).

## Binary Tree vs Binary Search Tree

| Feature        | Binary Tree      | BST                |
|---------------|------------------|--------------------|
| Ordering      | None             | Left < Root < Right|
| Search        | O(n)             | O(log n) balanced  |
| Insert        | O(n) level-order | O(log n) balanced  |
| Use case      | Expression trees  | Fast lookup        |
