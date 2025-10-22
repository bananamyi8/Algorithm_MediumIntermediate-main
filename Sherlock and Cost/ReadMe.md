Algorithm (Array Adjustment Maximum Cost):

Maintain two values at each step:

low: Max cost if current value is 1.

high: Max cost if current value is actual value B[i].

For every position from 1 to n-1:

Update possible costs for both states (using max of previous transitions and movement cost).

Assign new values to low and high.

At the end, return the max of low and high.