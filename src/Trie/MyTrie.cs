namespace Trie;

public class MyTrie
{
    private TrieNode root = new();

    // Insert a word into the trie
    // Time: O(m) where m = word length
    public void Insert(string word)
    {
        var current = root;

        foreach (char ch in word)
        {
            if (!current.Children.ContainsKey(ch))
                current.Children[ch] = new TrieNode();

            current = current.Children[ch];
        }

        current.IsEndOfWord = true;
    }

    // Search for an exact word
    // Time: O(m)
    public bool Search(string word)
    {
        var node = FindNode(word);
        return node != null && node.IsEndOfWord;
    }

    // Check if any word starts with the given prefix
    // Time: O(m)
    public bool StartsWith(string prefix)
    {
        return FindNode(prefix) != null;
    }

    // Delete a word from the trie
    // Time: O(m)
    public bool Delete(string word)
    {
        return DeleteRecursive(root, word, 0);
    }

    private bool DeleteRecursive(TrieNode node, string word, int index)
    {
        if (index == word.Length)
        {
            if (!node.IsEndOfWord)
                return false; // word doesn't exist

            node.IsEndOfWord = false;

            // Return true if this node has no children (can be removed)
            return node.Children.Count == 0;
        }

        char ch = word[index];

        if (!node.Children.ContainsKey(ch))
            return false; // word doesn't exist

        bool shouldDeleteChild = DeleteRecursive(node.Children[ch], word, index + 1);

        if (shouldDeleteChild)
        {
            node.Children.Remove(ch);
            // Return true if current node can also be removed
            return node.Children.Count == 0 && !node.IsEndOfWord;
        }

        return false;
    }

    // Get all words in the trie
    public List<string> GetAllWords()
    {
        var words = new List<string>();
        CollectWords(root, "", words);
        return words;
    }

    private void CollectWords(TrieNode node, string prefix, List<string> words)
    {
        if (node.IsEndOfWord)
            words.Add(prefix);

        foreach (var kvp in node.Children.OrderBy(x => x.Key))
            CollectWords(kvp.Value, prefix + kvp.Key, words);
    }

    private TrieNode? FindNode(string prefix)
    {
        var current = root;

        foreach (char ch in prefix)
        {
            if (!current.Children.ContainsKey(ch))
                return null;

            current = current.Children[ch];
        }

        return current;
    }
}
