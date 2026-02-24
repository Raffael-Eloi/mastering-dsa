Hash Tables (Dictionary / HashMap / HashSet)

A hash table gives you:

`⚡ Average O(1) lookup, insert, delete.`

Think of it like:
`Key → Hash Function → Array Index → Store Value`

Example:

`"apple" → hash → 3 → store in bucket[3]`

It converts a key into an array index.

## Core Components

A hash table has:
1. Array (buckets)
2. Hash function
3. Collision handling strategy

🔢 3️⃣ How Hashing Works

Simplified example:

int hash = key.GetHashCode();
int index = Math.Abs(hash % buckets.Length);

Why % buckets.Length?

Because we must fit inside the array size.

⚠️ 4️⃣ What Is a Collision?

Two keys may produce the same index.

Example:

"abc" → index 2
"xyz" → index 2

Now what?

This is called a collision.

We must handle it.

🧱 5️⃣ Collision Handling (Chaining)

Most common method: Linked List per bucket

Bucket[2]:
[abc → value1] → [xyz → value2]

⚡ Why Dictionary in C# Is So Fast

Dictionary<TKey, TValue> uses:

Hashing

Dynamic resizing

Load factor control

Rehashing

When size grows → it resizes and redistributes elements.

That keeps operations near O(1).