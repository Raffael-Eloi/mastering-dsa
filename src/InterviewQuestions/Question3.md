# Question 3: Longest Palindromic Substring

## Problem

Given a string `s`, return the longest substring that is a palindrome.
If there are multiple answers with the same length, return the first one found.

## Example

```
s = "babad"
Output: "bab"
(Note: "aba" is also a valid answer)

s = "cbbd"
Output: "bb"
```

## Function Signature

```
string LongestPalindrome(string s)
```

**Parameters:**
- `string s`: the input string

**Returns:**
- `string`: the longest palindromic substring

## Approach

Expand around center. For each index (and each gap between indices), expand outward
while the characters on both sides match. Track the longest palindrome found.

- There are 2n - 1 possible centers (n single characters + n - 1 gaps between them)
- Each expansion takes O(n) in the worst case
- Time: O(n^2), Space: O(1)
