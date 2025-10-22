Algorithm for Equal (Min Operations to Equalize Array):

Find the minimum value in the array (minVal).

Try base values: for baseVal = minVal, minVal - 1, ..., minVal - 4

For each base value:

Set operations = 0.

For each element val in arr:

Compute the difference: diff = val - baseVal

For each difference:

Add diff // 5 to operations. Update diff %= 5.

Add diff // 2 to operations. Update diff %= 2.

Add remaining diff to operations.

After finishing, update minOperations = min(minOperations, operations).

Return minOperations.