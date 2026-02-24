# LIFO - Stack (Last In, First Out)

A stack processes elements in reverse order — like a pile of plates.
The last plate placed on top is the first one removed.

## Operations

| Operation | Description           | Time |
|-----------|-----------------------|------|
| Push      | Add on top            | O(1) |
| Pop       | Remove from top       | O(1) |
| Peek      | View top element      | O(1) |
| IsEmpty   | Check if empty        | O(1) |

All operations are O(1) because we only interact with the top — no traversal needed.

## Two Implementations

### 1. Linked List Stack
- Top pointer always references the head node
- Push: new node becomes the new head
- Pop: move head to next node
- Dynamic size, no capacity limit

### 2. Array Stack
- Uses `top` index (starts at -1 = empty)
- Push: increment top, insert at that index
- Pop: return item at top, decrement
- Fixed capacity — throws on overflow

## When to Use a Stack

- **Undo/Redo**: each action is pushed; undo pops the last action
- **Expression evaluation**: matching parentheses, postfix calculation
- **DFS (Depth-First Search)**: explore as deep as possible before backtracking
- **Function call stack**: the runtime uses a stack to track method calls
- **Backtracking**: puzzles, mazes, recursive algorithms

## Array vs Linked List

| Feature          | Array Stack            | Linked List Stack      |
|-----------------|------------------------|------------------------|
| Capacity        | Fixed (must set size)  | Dynamic (grows freely) |
| Memory          | Pre-allocated block    | Per-node allocation    |
| Cache           | Better (contiguous)    | Worse (scattered)      |
| Overflow risk   | Yes                    | No (until out of RAM)  |
