# Question 1: Maximum and Minimum Median of Subsequences

## Problem

Given n integers (array `values`) and an integer `k`, find the maximum and minimum median
over all subsequences of length k.

## Example

Given n=3, values=[1,2,3], and k=2:

| Subsequences of length k | Median |
|--------------------------|--------|
| [1, 2]                   | 1      |
| [1, 3]                   | 1      |
| [2, 3]                   | 2      |

Maximum median = 2, Minimum median = 1.

## Function Signature

```
int[] Medians(int[] values, int k)
```

**Parameters:**
- `int[] values`: the array of integers
- `int k`: the subsequence length

**Returns:**
- `int[]`: [maximum median, minimum median] over all subsequences of length k.

## Approach

Sort the array. After sorting, the minimum median comes from taking the k smallest elements,
and the maximum median comes from taking the k largest elements.
The median index within a subsequence of length k is `m = (k - 1) / 2`.
