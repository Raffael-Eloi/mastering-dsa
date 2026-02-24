# FIFO - Queue (First In, First Out)

A queue processes elements in the order they arrive — like a line at the bank.
The first person in line is the first to be served.

## Operations

| Operation | Description          | Time |
|-----------|---------------------|------|
| Enqueue   | Add to the back     | O(1) |
| Dequeue   | Remove from front   | O(1) |
| Peek      | View front element  | O(1) |
| IsEmpty   | Check if empty      | O(1) |

## Two Implementations

### 1. Linked List Queue
- Uses head (front) and tail (back) pointers
- Enqueue adds at tail, Dequeue removes from head
- Dynamic size, no capacity limit
- Slightly more memory per element (pointer overhead)

### 2. Circular Queue (Array-based)
- Uses a fixed-size array with front and rear indices
- Wraps around using modulo: `rear = (rear + 1) % capacity`
- Avoids the O(n) shift problem of naive array queues
- Fixed capacity — must know max size upfront

## When to Use a Queue

- **BFS (Breadth-First Search)**: process nodes level by level
- **Task scheduling**: process jobs in arrival order
- **Buffering**: handle data streams (e.g., print queue, message queue)
- **Rate limiting**: process requests in order

## Why Circular Queue?

A naive array queue shifts all elements on dequeue — O(n).
A circular queue reuses freed slots by wrapping the index, keeping dequeue O(1).

```
Before dequeue: [10, 20, 30, _, _]  front=0, rear=3
After dequeue:  [_,  20, 30, _, _]  front=1, rear=3
Enqueue 40:     [_,  20, 30, 40, _] front=1, rear=4
Enqueue 50:     [50, 20, 30, 40, _] front=1, rear=0  <- wraps around!
```
