using Trie;

Console.WriteLine("=== Trie (Prefix Tree) ===\n");

var trie = new MyTrie();

// -----------------------------------------
// Insert words
// -----------------------------------------
Console.WriteLine("--- Insert ---");
string[] words = { "apple", "app", "application", "bat", "ball", "banana" };
foreach (var word in words)
    trie.Insert(word);
Console.WriteLine($"Inserted: {string.Join(", ", words)}");

// -----------------------------------------
// Search for exact words
// -----------------------------------------
Console.WriteLine("\n--- Search (exact match) ---");
Console.WriteLine($"Search 'apple':  {trie.Search("apple")}");   // True
Console.WriteLine($"Search 'app':    {trie.Search("app")}");     // True
Console.WriteLine($"Search 'ap':     {trie.Search("ap")}");      // False (prefix, not a word)
Console.WriteLine($"Search 'cat':    {trie.Search("cat")}");     // False

// -----------------------------------------
// Prefix matching
// -----------------------------------------
Console.WriteLine("\n--- StartsWith (prefix match) ---");
Console.WriteLine($"StartsWith 'app': {trie.StartsWith("app")}"); // True (apple, app, application)
Console.WriteLine($"StartsWith 'ba':  {trie.StartsWith("ba")}");  // True (bat, ball, banana)
Console.WriteLine($"StartsWith 'ca':  {trie.StartsWith("ca")}");  // False

// -----------------------------------------
// Get all words
// -----------------------------------------
Console.WriteLine("\n--- All words in trie ---");
Console.WriteLine($"[{string.Join(", ", trie.GetAllWords())}]");

// -----------------------------------------
// Delete
// -----------------------------------------
Console.WriteLine("\n--- Delete ---");
trie.Delete("app");
Console.WriteLine("Deleted 'app'");
Console.WriteLine($"Search 'app':    {trie.Search("app")}");     // False
Console.WriteLine($"Search 'apple':  {trie.Search("apple")}");   // True (still exists)
Console.WriteLine($"\nRemaining words: [{string.Join(", ", trie.GetAllWords())}]");
