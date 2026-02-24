using LIFO;

Console.WriteLine("=== LIFO (Stack) ===\n");

// -----------------------------------------
// Stack using Linked List
// -----------------------------------------
Console.WriteLine("--- Stack (Linked List) ---");
var stack = new StackUsingLinkedList();

stack.Push(10);
stack.Push(20);
stack.Push(30);
Console.WriteLine("Pushed: 10, 20, 30");

Console.WriteLine($"Peek: {stack.Peek()}");     // 30
Console.WriteLine($"Pop: {stack.Pop()}");        // 30
Console.WriteLine($"Pop: {stack.Pop()}");        // 20
Console.WriteLine($"IsEmpty: {stack.IsEmpty()}"); // False
Console.WriteLine($"Pop: {stack.Pop()}");        // 10
Console.WriteLine($"IsEmpty: {stack.IsEmpty()}"); // True

// -----------------------------------------
// Stack using Array
// -----------------------------------------
Console.WriteLine("\n--- Stack (Array, capacity=5) ---");
var arrayStack = new ArrayStack(5);

arrayStack.Push(100);
arrayStack.Push(200);
arrayStack.Push(300);
Console.WriteLine("Pushed: 100, 200, 300");

Console.WriteLine($"Peek: {arrayStack.Peek()}");  // 300
Console.WriteLine($"Pop: {arrayStack.Pop()}");     // 300
Console.WriteLine($"Pop: {arrayStack.Pop()}");     // 200
Console.WriteLine($"Pop: {arrayStack.Pop()}");     // 100

// Demonstrate stack overflow protection
Console.WriteLine("\n--- Overflow/Underflow Demo ---");
var tinyStack = new ArrayStack(2);
tinyStack.Push(1);
tinyStack.Push(2);
try
{
    tinyStack.Push(3); // should throw
}
catch (Exception ex)
{
    Console.WriteLine($"Push to full stack: {ex.Message}");
}

tinyStack.Pop();
tinyStack.Pop();
try
{
    tinyStack.Pop(); // should throw
}
catch (Exception ex)
{
    Console.WriteLine($"Pop from empty stack: {ex.Message}");
}
