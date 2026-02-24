# Binary Search Tree (BST)

A BST is a binary tree where for every node:
- **Left** subtree contains only **smaller** values
- **Right** subtree contains only **larger** values

```
        8
      /   \
     3     10
    / \      \
   1   6      14
      / \     /
     4   7   13
```

This ordering enables fast search — at each step you eliminate half the tree.

## Operations

| Operation | Balanced   | Worst (skewed) |
|-----------|-----------|----------------|
| Insert    | O(log n)  | O(n)           |
| Search    | O(log n)  | O(n)           |
| Delete    | O(log n)  | O(n)           |

### Delete has 3 cases:

1. **Leaf node** (no children): simply remove it
2. **One child**: replace node with its child
3. **Two children**: find the in-order successor (smallest in right subtree),
   copy its value, then delete the successor

## Traversals

| Traversal  | Order               | BST Result     |
|-----------|---------------------|----------------|
| In-Order  | Left, Root, Right   | Sorted output  |
| Pre-Order | Root, Left, Right   | Tree structure |
| Post-Order| Left, Right, Root   | Bottom-up      |

In-Order on a BST always produces sorted output — this is a key property.

## Balanced vs Unbalanced

A BST can become **skewed** if you insert sorted data:

```
Inserting 1, 2, 3, 4 creates:     Balanced tree:
1                                       2
 \                                     / \
  2                                   1   3
   \                                       \
    3                                       4
     \
      4

Height: 4 (O(n))                  Height: 3 (O(log n))
```

Self-balancing trees (AVL, Red-Black) prevent this by rebalancing after each insert.

## When to Use

- Need sorted data with fast insert/delete (better than re-sorting an array)
- Ordered iteration (in-order traversal)
- Range queries (find all values between X and Y)
