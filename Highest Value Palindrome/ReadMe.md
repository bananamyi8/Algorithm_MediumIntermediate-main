Algorithm (Highest Value Palindrome):

First pass:

Make string a palindrome using minimal changes:

Iterate pairs from both ends (left, right).

If characters differ, set both to the higher one, mark as changed, and decrement allowed changes k.

If k drops below 0, return -1 (not enough changes).

Second pass:

Iterate again to maximize palindrome value (turn digits to '9' when possible).

For each pair, if not '9', calculate cost:

Cost is 1 if pair was changed in first pass, else 2.

If enough k, change both to '9' and decrement k.

For odd-length strings, can change middle digit to '9' if possible.

Return palindrome.