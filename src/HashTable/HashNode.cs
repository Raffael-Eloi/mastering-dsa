namespace HashTable;

public class HashNode
{
    public string Key;
    public int Value;
    public HashNode? Next;

    public HashNode(string key, int value)
    {
        Key = key;
        Value = value;
    }
}