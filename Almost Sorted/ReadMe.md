Algorithm (Almost Sorted):

Compare the input array to its sorted version, find all indices where they differ.

If no difference, already sorted: print "yes".

If exactly two differences, can fix by swapping: print "yes" and swap indices.

If more than two, check if differences are contiguous and reversing that subarray sorts the array:

If so, print "yes" and reverse indices.

Else, print "no".