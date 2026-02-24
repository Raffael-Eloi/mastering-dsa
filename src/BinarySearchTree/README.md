🌳 1️⃣ What Is a Binary Search Tree?

A BST is a special kind of binary tree where:

For every node:

Left subtree contains smaller values

Right subtree contains larger values

Example:

        8
      /   \
     3     10
    / \      \
   1   6      14
      / \     /
     4   7   13

This property enables fast search.

🧠 Why It’s Powerful

Because at each step, you eliminate half of the tree — just like binary search.

If balanced:

Time complexity → O(log n)