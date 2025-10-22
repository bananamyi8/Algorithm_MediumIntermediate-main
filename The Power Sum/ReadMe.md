Algorithm (Count Power Sum Ways):

At each step, try to include or skip the current number raised to power N.

If the powered value is greater than X, return 0 ❌
If powered value is exactly X, return 1 ✅
Otherwise, recurse for both:

Include current (subtract power from X, increment num)

Skip current (keep X, increment num)

The answer is the sum of both choices.