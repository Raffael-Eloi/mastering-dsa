# Hash Table (Dictionary / HashMap)

A hash table stores key-value pairs with average O(1) lookup, insert, and delete.

How it works:

```
Key -> Hash Function -> Array Index -> Store Value
"apple" -> hash -> 3 -> bucket[3]
```

## Core Components

1. **Array (buckets)** — storage slots
2. **Hash function** — converts key to index: `Math.Abs(key.GetHashCode() % size)`
3. **Collision handling** — what happens when two keys map to the same index

## Complexity

| Operation | Average | Worst Case |
|-----------|---------|------------|
| Add       | O(1)    | O(n)       |
| Get       | O(1)    | O(n)       |
| Remove    | O(1)    | O(n)       |

Worst case happens when all keys collide into the same bucket.
In practice this is rare with a good hash function.

## Collisions

Two keys can produce the same index:

```
"abc" -> index 2
"xyz" -> index 2   <- collision!
```

### Chaining (our implementation)

Each bucket is a linked list. Colliding keys are appended:

```
bucket[2]: [abc, value1] -> [xyz, value2]
```

### Other strategies (not implemented)

- **Open addressing**: probe the next empty slot
- **Robin Hood hashing**: steal from rich buckets
- **Cuckoo hashing**: use two hash functions

## Why C# Dictionary Is Fast

`Dictionary<TKey, TValue>` uses:
- Hashing for O(1) access
- Dynamic resizing when load factor exceeds threshold
- Rehashing to redistribute keys across larger array

This keeps operations near O(1) even as the collection grows.

## When to Use

- Fast lookups by key (caching, counting, indexing)
- Checking membership (have I seen this value before?)
- Grouping data by a key
