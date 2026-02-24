🧠 1️⃣ What Is a Priority Queue?

A Priority Queue is:

A data structure where elements are removed based on priority, not insertion order.

Usually implemented with a Binary Heap.

We’ll implement a Min Heap:

Smallest element always at index 0.

🧱 2️⃣ Heap Structure (Array Representation)

A heap is a complete binary tree.

Stored in array form:

Index:  0  1  2  3  4  5  6
Value: [1, 3, 5, 7, 9, 6, 8]

Relationships:

Parent = (i - 1) / 2
Left   = 2*i + 1
Right  = 2*i + 2

This is crucial. Memorize this.