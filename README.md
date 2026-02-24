# Mastering Data Structures & Algorithms

A hands-on C# (.NET 10) repository for learning fundamental data structures and algorithms.
Each topic is a standalone console project that you can run and study independently.

## Study Order

### Data Structures
| #   | Topic              | Project               | Key Concepts                              |
|-----|--------------------|------------------------|-------------------------------------------|
| 0   | Big O Notation     | `BigONotation`         | O(1), O(n), O(n^2), O(log n), O(n log n) |
| 1   | Linked List        | `LinkedList`           | Singly linked list, node pointers         |
| 2   | Queue (FIFO)       | `FIFO`                 | Circular queue, linked list queue         |
| 3   | Stack (LIFO)       | `LIFO`                 | Array stack, linked list stack            |
| 4   | Hash Table         | `HashTable`            | Hashing, collision handling (chaining)    |
| 5   | Binary Tree        | `BinaryTree`           | Traversals: in/pre/post/level-order       |
| 6   | Binary Search Tree | `BinarySearchTree`     | Insert, search, delete, BST property     |
| 7   | Binary Search      | `BinarySearch`         | Iterative and recursive approaches        |
| 8   | Sorting Algorithms | `SortingAlgorithms`    | Bubble, Insertion, Merge, Quick, Heap     |
| 9   | Doubly Linked List | `DoublyLinkedList`     | Two-way traversal, O(1) remove from both ends |
| 10  | Graph              | `Graph`                | BFS, DFS, cycle detection, Dijkstra      |
| 11  | Trie               | `Trie`                 | Prefix tree, insert, search, autocomplete |

### Algorithm Patterns
| #   | Topic                    | Project                | Key Concepts                              |
|-----|--------------------------|------------------------|-------------------------------------------|
| 12  | Recursion & Backtracking | `RecursionBacktracking`| Factorial, subsets, permutations, N-Queens|
| 13  | Dynamic Programming      | `DynamicProgramming`   | Memoization, tabulation, knapsack, LCS   |
| 14  | Two Pointers             | `TwoPointers`          | Converging, fast/slow, sliding window     |
| 15  | Greedy Algorithms        | `GreedyAlgorithms`     | Activity selection, fractional knapsack   |

### Practice
| #   | Topic              | Project               | Key Concepts                              |
|-----|--------------------|------------------------|-------------------------------------------|
| 999 | Interview Questions| `InterviewQuestions`   | Real coding interview problems            |

## How to Run

Each project is a standalone console app. Run any project with:

```bash
dotnet run --project src/BigONotation
dotnet run --project src/LinkedList
dotnet run --project src/FIFO
dotnet run --project src/LIFO
dotnet run --project src/HashTable
dotnet run --project src/BinaryTree
dotnet run --project src/BinarySearchTree
dotnet run --project src/BinarySearch
dotnet run --project src/SortingAlgorithms
dotnet run --project src/DoublyLinkedList
dotnet run --project src/Graph
dotnet run --project src/Trie
dotnet run --project src/RecursionBacktracking
dotnet run --project src/DynamicProgramming
dotnet run --project src/TwoPointers
dotnet run --project src/GreedyAlgorithms
dotnet run --project src/InterviewQuestions
```

Build the entire solution:

```bash
dotnet build Mastering.DSA.slnx
```

Run unit tests:

```bash
dotnet test
```

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Structure

```
src/
  BigONotation/          - Time & space complexity examples
  LinkedList/            - Singly linked list with core operations
  FIFO/                  - Queue (circular array + linked list)
  LIFO/                  - Stack (array + linked list)
  HashTable/             - Hash table with chaining
  BinaryTree/            - Binary tree with 4 traversal types
  BinarySearchTree/      - BST with insert, search, delete
  BinarySearch/          - Binary search (iterative + recursive)
  SortingAlgorithms/     - 5 sorting algorithms + priority queue
  DoublyLinkedList/      - Doubly linked list with bidirectional traversal
  Graph/                 - Graph with BFS, DFS, Dijkstra
  Trie/                  - Prefix tree for string operations
  RecursionBacktracking/ - Recursion, subsets, permutations, N-Queens
  DynamicProgramming/    - Fibonacci, coin change, knapsack, LCS
  TwoPointers/           - Two pointers and sliding window patterns
  GreedyAlgorithms/      - Activity selection, fractional knapsack, jump game
  InterviewQuestions/    - Real interview problems with solutions
tests/
  Mastering.DSA.Tests/   - NUnit tests for data structure implementations
```

Each project folder contains:
- `Program.cs` — runnable demo with output
- Implementation classes (e.g., `MyLinkedList.cs`, `MyGraph.cs`)
- `README.md` — concept explanation with complexity analysis
