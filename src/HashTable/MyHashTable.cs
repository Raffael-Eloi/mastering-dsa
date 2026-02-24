using System.Timers;

namespace HashTable;

public class MyHashTable
{
    private HashNode?[] buckets;
    private int size;

    public MyHashTable(int capacity = 10)
    {
        buckets = new HashNode[capacity];
        size = capacity;
    }

    private int GetIndex(string key)
    {
        int hash = key.GetHashCode();
        return Math.Abs(hash % size);
    }

    public void Add(string key, int value)
    {
        int index = GetIndex(key);

        var newNode = new HashNode(key, value);

        if (buckets[index] == null)
        {
            buckets[index] = newNode;
            return;
        }

        var current = buckets[index];

        while (true)
        {
            if (current!.Key == key)
            {
                current.Value = value;
                return;
            }

            if (current.Next == null)
                break;

            current = current.Next;
        }

        current.Next = newNode;
    }

    public int? Get(string key)
    {
        int index = GetIndex(key);

        var current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;

            current = current.Next;
        }

        return null;
    }

    public void Remove(string key)
    {
        int index = GetIndex(key);

        var current = buckets[index];
        HashNode? previous = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (previous == null)
                    buckets[index] = current.Next;
                else
                    previous.Next = current.Next;

                return;
            }

            previous = current;
            current = current.Next;
        }
    }
}
/*
Time Complexity(Important)

Operation Average Worst Case
Add O(1)    O(n)
Get O(1)    O(n)
Remove O(1)    O(n)

Worst case happens if all keys collide.

In practice → rare with good hash functions.
*/