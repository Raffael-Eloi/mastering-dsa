# Question 2: Minimum Cost to Make Concurrency Limits Distinct

## Problem

You're the on-call SDE for a serverless production stack. The architecture
includes n AWS Lambda functions, and each function i currently has a reserved
concurrency limit of `conc[i]`. Because burst load on one function can starve
others, your principal engineer asks that every function end up with a distinct
concurrency limit.

In one operation you may raise function i's limit by exactly 1, incurring a cost
of `price[i]` (the cost reflects additional provisioned-concurrency dollars).

Find the minimum total cost to make all concurrency limits distinct.

## Example

```
n = 5
conc  = [5, 2, 5, 3, 3]
price = [3, 7, 8, 6, 9]
```

An optimal sequence:
- Bump function 0 (conc[0]) from 5 -> 6, cost = 3
- Bump function 3 (conc[3]) from 3 -> 4, cost = 6

Final limits: [6, 2, 5, 4, 3] — all different. Total cost = 3 + 6 = **9**.

## Approach

1. Pair each function's concurrency with its price
2. Sort by concurrency (ascending), then by price (descending for ties)
3. Greedily iterate: if current concurrency <= previous, bump it to previous + 1
4. When bumping, prefer to bump the cheapest functions (sorting by descending price
   ensures expensive ones keep their original value when possible)
