Algorithm (Max Subarray & Subsequence Sums):

Find the max contiguous subarray sum using Kadane’s algorithm:

For each number, track the maximum sum ending at that point.

Update the global maximum as you go.

Find the max non-contiguous subsequence sum:

If array contains positive numbers, sum all positives.

Else, take the largest (least negative) single value.

Return both sums.