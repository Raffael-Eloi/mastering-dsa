# Insertion Sort

## Idea

Build the sorted portion one element at a time — like sorting cards in your hand.
Pick each element and insert it into the correct position in the already-sorted part.

## Step-by-Step

```
[64, 34, 25, 12]

Step 1: key=34, insert into [64]
  34 < 64 -> shift 64 right -> [34, 64, 25, 12]

Step 2: key=25, insert into [34, 64]
  25 < 64 -> shift 64 right
  25 < 34 -> shift 34 right -> [25, 34, 64, 12]

Step 3: key=12, insert into [25, 34, 64]
  12 < 64 -> shift
  12 < 34 -> shift
  12 < 25 -> shift -> [12, 25, 34, 64]  <- sorted!
```

## Complexity

| Case    | Time   | Why                                |
|---------|--------|------------------------------------|
| Best    | O(n)   | Already sorted, no shifts needed   |
| Average | O(n^2) | Half the elements need shifting    |
| Worst   | O(n^2) | Reverse sorted, every element shifts|

Space: O(1) — in-place, stable sort.

## When to Use

- Small datasets (faster than merge/quick sort due to low overhead)
- Nearly sorted data (approaches O(n))
- Online sorting (can sort elements as they arrive)
- Used as the base case in hybrid sorts (e.g., Timsort uses insertion sort for small runs)
