Algorithm Overview (Palindrome substring count by character counts):

Initialization (initialize)
Precompute factorials and inverse factorials up to MAX for combinatorics.

For the string, build prefix sums for each character:

At every position, keep cumulative counts for each letter.

Query (answerQuery)
For substring [l, r], get character counts via prefix sums.

Count number of pairs and odd singles among the character counts.

Total palindrome arrangements =

Choose places for pairs (using multinomial coefficient).

Multiply by number of choices for center character (if odds > 0).