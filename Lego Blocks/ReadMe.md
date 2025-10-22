Algorithm (Lego Blocks Stable Wall Count):

Count ways to build one row of width i (rowWays[i]):

For each width from 1 to m:

Sum ways for all possible last block sizes (1–4).

Find ways to build a wall of height n and width i (totalWays[i]):

For each width, take rowWays[i] to the power of n.

Find the number of stable walls (stableWays[i]):

For each width, subtract the number of unstable walls (walls that can be split vertically).

Use inclusion-exclusion to count unstable arrangements.

Return stable ways for wall width m.