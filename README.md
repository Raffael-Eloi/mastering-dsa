# Mastering Data Structures & Algorithms

A hands-on C# (.NET 10) repository for learning fundamental data structures and algorithms.
Each topic is a standalone console project that you can run and study independently.

## Study Order

| #   | Topic              | Project             | Key Concepts                              |
|-----|--------------------|----------------------|-------------------------------------------|
| 0   | Big O Notation     | `BigONotation`       | O(1), O(n), O(n^2), O(log n), O(n log n) |
| 1   | Linked List        | `LinkedList`         | Singly linked list, node pointers         |
| 2   | Queue (FIFO)       | `FIFO`               | Circular queue, linked list queue         |
| 3   | Stack (LIFO)       | `LIFO`               | Array stack, linked list stack            |
| 4   | Hash Table         | `HashTable`          | Hashing, collision handling (chaining)    |
| 5   | Binary Tree        | `BinaryTree`         | Traversals: in/pre/post/level-order       |
| 6   | Binary Search Tree | `BinarySearchTree`   | Insert, search, delete, BST property     |
| 7   | Binary Search      | `BinarySearch`       | Iterative and recursive approaches        |
| 8   | Sorting Algorithms | `SortingAlgorithms`  | Bubble, Insertion, Merge, Quick, Heap     |
| 999 | Interview Questions| `InterviewQuestions`  | Real coding interview problems            |

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
dotnet run --project src/InterviewQuestions
```

Or build the entire solution:

```bash
dotnet build Mastering.DSA.slnx
```

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Structure

```
src/
  BigONotation/        - Time & space complexity examples
  LinkedList/          - Singly linked list with core operations
  FIFO/                - Queue (circular array + linked list implementations)
  LIFO/                - Stack (array + linked list implementations)
  HashTable/           - Hash table with chaining for collision handling
  BinaryTree/          - Binary tree with 4 traversal types
  BinarySearchTree/    - BST with insert, search, delete
  BinarySearch/        - Binary search (iterative + recursive)
  SortingAlgorithms/   - 5 sorting algorithms + priority queue (min heap)
  InterviewQuestions/  - Real interview problems with solutions
```

Each project folder contains:
- `Program.cs` — runnable demo with output
- Implementation classes (e.g., `MyLinkedList.cs`, `MyHashTable.cs`)
- `README.md` — concept explanation with complexity analysis
