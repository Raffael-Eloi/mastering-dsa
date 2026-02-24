# Graph

A graph is a collection of **vertices** (nodes) connected by **edges**.
Unlike trees, graphs can have cycles, multiple paths, and no root.

## Representations

### Adjacency List (our implementation)

Each vertex stores a list of its neighbors. Efficient for sparse graphs.

```
0 -> [1, 2]
1 -> [0, 3]
2 -> [0, 3]
3 -> [1, 2, 4]
4 -> [3]
```

### Adjacency Matrix

A 2D array where `matrix[i][j] = 1` if edge exists. Better for dense graphs.

```
  0 1 2 3 4
0 [0 1 1 0 0]
1 [1 0 0 1 0]
2 [1 0 0 1 0]
3 [0 1 1 0 1]
4 [0 0 0 1 0]
```

| Feature          | Adjacency List | Adjacency Matrix |
|-----------------|----------------|-----------------|
| Space           | O(V + E)       | O(V^2)          |
| Add edge        | O(1)           | O(1)            |
| Check edge      | O(degree)      | O(1)            |
| Find neighbors  | O(degree)      | O(V)            |
| Best for        | Sparse graphs  | Dense graphs    |

## Traversals

### BFS (Breadth-First Search)

Explore level by level using a **queue**. Visits nearest vertices first.

- Time: O(V + E)
- Use cases: shortest path (unweighted), level-order traversal

### DFS (Depth-First Search)

Explore as deep as possible, then backtrack, using a **stack** (or recursion).

- Time: O(V + E)
- Use cases: cycle detection, topological sort, connected components

## Cycle Detection

For directed graphs, use 3-color DFS:
- **White**: unvisited
- **Gray**: in current DFS path
- **Black**: fully explored

If we encounter a gray node during DFS, there's a cycle (back edge).

## Dijkstra's Algorithm

Finds the shortest path from a source to all other vertices in a **weighted graph** (no negative weights).

1. Set all distances to infinity, source to 0
2. Use a priority queue to always process the nearest unvisited vertex
3. For each neighbor, update distance if a shorter path is found

Time: O((V + E) log V) with priority queue.

## When to Use Graphs

- Social networks (friends, followers)
- Maps and navigation (shortest route)
- Dependency resolution (build systems, task scheduling)
- Web crawling (pages linked to pages)
