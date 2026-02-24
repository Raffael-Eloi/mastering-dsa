using HashTable;

var table = new MyHashTable();

table.Add("apple", 10);
table.Add("banana", 20);

Console.WriteLine(table.Get("apple")); // 10

table.Remove("apple");

Console.WriteLine(table.Get("apple")); // null