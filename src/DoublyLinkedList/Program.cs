using DoublyLinkedList;

Console.WriteLine("=== Doubly Linked List ===\n");

var list = new MyDoublyLinkedList();

// AddLast - O(1) because we track tail
Console.WriteLine("--- AddLast ---");
list.AddLast(10);
list.AddLast(20);
list.AddLast(30);
list.PrintForward(); // 10 <-> 20 <-> 30 <-> null

// AddFirst - O(1)
Console.WriteLine("\n--- AddFirst(5) ---");
list.AddFirst(5);
list.PrintForward(); // 5 <-> 10 <-> 20 <-> 30 <-> null

// Reverse traversal - unique to doubly linked list
Console.WriteLine("\n--- PrintReverse ---");
list.PrintReverse(); // 30 <-> 20 <-> 10 <-> 5 <-> null

// Contains
Console.WriteLine($"\n--- Contains ---");
Console.WriteLine($"Contains 20: {list.Contains(20)}"); // True
Console.WriteLine($"Contains 99: {list.Contains(99)}"); // False

// Count
Console.WriteLine($"\nCount: {list.Count()}"); // 4

// RemoveFirst - O(1)
Console.WriteLine("\n--- RemoveFirst ---");
Console.WriteLine($"Removed: {list.RemoveFirst()}"); // 5
list.PrintForward(); // 10 <-> 20 <-> 30 <-> null

// RemoveLast - O(1) (vs O(n) in singly linked list!)
Console.WriteLine("\n--- RemoveLast ---");
Console.WriteLine($"Removed: {list.RemoveLast()}"); // 30
list.PrintForward(); // 10 <-> 20 <-> null

Console.WriteLine($"\nFinal count: {list.Count()}"); // 2
