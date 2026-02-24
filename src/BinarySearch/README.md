🧠 1️⃣ What Is Binary Search?

Binary Search works only on:

✅ Sorted data

It reduces the search space by half every iteration.

Instead of checking every element (O(n)),
we cut the array in half repeatedly → O(log n).

📉 Visual Intuition

Array:

[1, 3, 5, 7, 9, 11, 13]

Looking for 9.

Check middle → 7

9 > 7 → search right half

Check middle → 11

9 < 11 → search left half

Found 9

Each step cuts the search space in half.

📊 Why It’s O(log n)

Each iteration:

n → n/2 → n/4 → n/8 → ...

How many times can you divide n by 2 until 1?

Answer:

log₂(n)

That’s why it’s O(log n).