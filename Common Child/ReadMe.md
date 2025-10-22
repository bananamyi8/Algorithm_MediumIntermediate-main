Algorithm for Common Child (LCS):

Initialize a DP table:

Let n be the length of both strings (s1, s2).

Create a two-dimensional array dp of size (n+1) x (n+1), initialized to zero.

Iterate over both strings:

For each i from 1 to n:

For each j from 1 to n:

If s1[i-1] == s2[j-1]:

Set dp[i, j] = dp[i-1, j-1] + 1

Else:

Set dp[i, j] = max(dp[i-1, j], dp[i, j-1])

Return the result:

The length of the longest common subsequence is stored in dp[n, n].

