using FIFO;

Console.WriteLine("=== FIFO (Queue) ===\n");

// -----------------------------------------
// Queue using Linked List
// -----------------------------------------
Console.WriteLine("--- Queue (Linked List) ---");
var queue = new QueueUsingLinkedList();

queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);
Console.WriteLine("Enqueued: 10, 20, 30");

Console.WriteLine($"Peek: {queue.Peek()}");       // 10
Console.WriteLine($"Dequeue: {queue.Dequeue()}");  // 10
Console.WriteLine($"Dequeue: {queue.Dequeue()}");  // 20
Console.WriteLine($"Peek: {queue.Peek()}");        // 30
Console.WriteLine($"IsEmpty: {queue.IsEmpty()}");   // False
Console.WriteLine($"Dequeue: {queue.Dequeue()}");  // 30
Console.WriteLine($"IsEmpty: {queue.IsEmpty()}");   // True

// -----------------------------------------
// Circular Queue (Array-based)
// -----------------------------------------
Console.WriteLine("\n--- Circular Queue (Array, capacity=3) ---");
var circular = new CircularQueue(3);

circular.Enqueue(100);
circular.Enqueue(200);
circular.Enqueue(300);
Console.WriteLine("Enqueued: 100, 200, 300");

Console.WriteLine($"Dequeue: {circular.Dequeue()}"); // 100

// After dequeue, there's room to enqueue again (circular wraparound)
circular.Enqueue(400);
Console.WriteLine("Enqueued: 400 (reused slot from dequeue)");

Console.WriteLine($"Dequeue: {circular.Dequeue()}"); // 200
Console.WriteLine($"Dequeue: {circular.Dequeue()}"); // 300
Console.WriteLine($"Dequeue: {circular.Dequeue()}"); // 400

Console.WriteLine("\nCircular queue reuses array slots efficiently!");
