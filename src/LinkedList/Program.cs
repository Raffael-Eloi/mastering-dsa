using LinkedList;

Console.WriteLine("=== Linked List ===\n");

var list = new MyLinkedList();

// AddLast - O(n)
Console.WriteLine("--- AddLast ---");
list.AddLast(10);
list.AddLast(20);
list.AddLast(30);
list.AddLast(40);
list.Print(); // 10 -> 20 -> 30 -> 40 -> null

// AddFirst - O(1)
Console.WriteLine("\n--- AddFirst(5) ---");
list.AddFirst(5);
list.Print(); // 5 -> 10 -> 20 -> 30 -> 40 -> null

// Contains - O(n)
Console.WriteLine("\n--- Contains ---");
Console.WriteLine($"Contains 20: {list.Contains(20)}"); // True
Console.WriteLine($"Contains 99: {list.Contains(99)}"); // False

// Count - O(n)
Console.WriteLine($"\n--- Count: {list.Count()} ---");

// RemoveFirst - O(1)
Console.WriteLine("\n--- RemoveFirst ---");
Console.WriteLine($"Removed: {list.RemoveFirst()}"); // 5
list.Print(); // 10 -> 20 -> 30 -> 40 -> null

// RemoveLast - O(n)
Console.WriteLine("\n--- RemoveLast ---");
Console.WriteLine($"Removed: {list.RemoveLast()}"); // 40
list.Print(); // 10 -> 20 -> 30 -> null

Console.WriteLine($"\nFinal count: {list.Count()}");
