using LIFO;

var stack = new StackUsingLinkedList();

stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine(stack.Pop()); // 30
Console.WriteLine(stack.Pop()); // 20