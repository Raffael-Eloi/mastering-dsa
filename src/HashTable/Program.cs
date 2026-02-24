using HashTable;

Console.WriteLine("=== Hash Table ===\n");

// -----------------------------------------
// Basic Operations
// -----------------------------------------
Console.WriteLine("--- Basic Operations ---");
var table = new MyHashTable();

table.Add("apple", 10);
table.Add("banana", 20);
table.Add("cherry", 30);
Console.WriteLine("Added: apple=10, banana=20, cherry=30");

Console.WriteLine($"Get apple:  {table.Get("apple")}");   // 10
Console.WriteLine($"Get banana: {table.Get("banana")}");   // 20
Console.WriteLine($"Get cherry: {table.Get("cherry")}");   // 30
Console.WriteLine($"Get grape:  {table.Get("grape")}");    // null (not found)

// -----------------------------------------
// Update existing key
// -----------------------------------------
Console.WriteLine("\n--- Update ---");
table.Add("apple", 99);
Console.WriteLine($"Updated apple to 99: {table.Get("apple")}"); // 99

// -----------------------------------------
// Remove
// -----------------------------------------
Console.WriteLine("\n--- Remove ---");
table.Remove("banana");
Console.WriteLine($"After removing banana: {table.Get("banana")}"); // null

// -----------------------------------------
// Collision demonstration
// -----------------------------------------
Console.WriteLine("\n--- Collision Handling ---");
// With a small table size, collisions are likely
var smallTable = new MyHashTable(2); // only 2 buckets
smallTable.Add("cat", 1);
smallTable.Add("dog", 2);
smallTable.Add("fish", 3);
smallTable.Add("bird", 4);
Console.WriteLine("Added 4 keys to a 2-bucket table (collisions guaranteed):");
Console.WriteLine($"  cat:  {smallTable.Get("cat")}");   // 1
Console.WriteLine($"  dog:  {smallTable.Get("dog")}");   // 2
Console.WriteLine($"  fish: {smallTable.Get("fish")}");  // 3
Console.WriteLine($"  bird: {smallTable.Get("bird")}");  // 4
Console.WriteLine("All values retrieved correctly despite collisions (chaining).");
