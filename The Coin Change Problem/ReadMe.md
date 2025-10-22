Algorithm (Count Coin Change Ways):

Initialize a ways array: ways[0] = 1

For each coin in the set:

For every sum from coin value up to n:

Increment ways for that sum by ways of sum minus coin value.

Return total ways for amount n.