# Greedy Algorithms

A greedy algorithm makes the **locally optimal choice** at each step, hoping to find
the global optimum. It never reconsiders a choice once made.

## Greedy Choice Property

A problem is solvable by greedy if making the best local choice at each step leads
to the best overall solution. Not all problems have this property.

## Greedy vs Dynamic Programming

| Feature         | Greedy               | DP                     |
|----------------|----------------------|------------------------|
| Approach       | Local optimal choice | Consider all options   |
| Reconsiders    | Never                | Stores all subproblems |
| Speed          | Usually faster       | Usually slower         |
| Correctness    | Only if greedy works | Always correct         |
| Example        | Activity Selection   | 0/1 Knapsack           |

**Key difference**: Fractional Knapsack is solvable by greedy (take by best ratio).
0/1 Knapsack is NOT (must use DP because you can't take fractions).

## Problems in This Project

| Problem              | Greedy Choice                        | Time       |
|---------------------|--------------------------------------|------------|
| Activity Selection  | Pick earliest finishing activity     | O(n log n) |
| Fractional Knapsack | Pick highest value/weight ratio      | O(n log n) |
| Jump Game           | Track farthest reachable position    | O(n)       |

## Activity Selection

Sort by end time. Always pick the activity that finishes earliest and doesn't
overlap with the last selected activity.

Why it works: choosing the earliest finish leaves the most room for future activities.

## Fractional Knapsack

Sort by value/weight ratio. Take items with the highest ratio first.
If an item doesn't fit entirely, take a fraction of it.

## Jump Game

Track the farthest index you can reach. If your current position exceeds the
farthest reachable, you're stuck.

## When Greedy Works

- The problem has **greedy choice property** (local optimal = global optimal)
- The problem has **optimal substructure**
- Common signs: sorting helps, you can make irrevocable decisions

## When Greedy Fails

- 0/1 Knapsack: taking the best ratio item might prevent a better combination
- Coin change (general): greedy (take largest coin) fails for some coin sets
  - Example: coins [1, 3, 4], amount 6: greedy gives 4+1+1=3 coins, optimal is 3+3=2 coins
