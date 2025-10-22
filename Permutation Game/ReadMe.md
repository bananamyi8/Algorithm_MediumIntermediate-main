Algorithm (Permutation Game):

Recursion with memoization checks if Alice, as the starting player, can always force a win.

If array is sorted, current player loses.

For each possible element to remove:

If removing it leads to a position where next player cannot win, current player wins.

Otherwise, current player loses.