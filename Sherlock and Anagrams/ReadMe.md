Algorithm (Count Unordered Anagram Pairs):

Generate all substrings of the string.

For each substring:

Sort characters to make the substring's "anagram signature".

Use a dictionary to count occurrences of each signature.

For each repeat occurrence, increment a running total by the dictionary's current count (counts all pairs).

Return total anagram pairs.