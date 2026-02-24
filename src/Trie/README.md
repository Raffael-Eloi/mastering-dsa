# Trie (Prefix Tree)

A trie is a tree-like data structure for storing strings, where each node represents
a single character. Common prefixes share the same path.

## Structure

Storing "app", "apple", "bat":

```
       (root)
      /      \
     a        b
     |        |
     p        a
     |        |
     p*       t*
     |
     l
     |
     e*

* = end of word
```

"app" and "apple" share the path `a -> p -> p`.

## Complexity

| Operation  | Time  | Notes                    |
|-----------|-------|--------------------------|
| Insert    | O(m)  | m = length of the word   |
| Search    | O(m)  | Exact word match         |
| StartsWith| O(m)  | Prefix match             |
| Delete    | O(m)  | Remove word, clean up    |

Space: O(N * M) where N = number of words, M = average word length.
In practice, shared prefixes reduce actual space significantly.

## vs Hash Table

| Feature          | Trie          | Hash Table     |
|-----------------|---------------|----------------|
| Prefix search   | O(m)          | Not supported  |
| Exact search    | O(m)          | O(1) average   |
| Ordered results | Yes (natural) | No             |
| Space           | Higher        | Lower          |

Tries win when you need prefix operations; hash tables win for exact lookups.

## When to Use

- **Autocomplete**: find all words starting with a prefix
- **Spell checker**: suggest corrections by searching nearby prefixes
- **IP routing**: longest prefix matching in network routers
- **Word games**: validate words efficiently (Scrabble, Wordle)
- **Dictionary**: store and retrieve words with shared prefixes
