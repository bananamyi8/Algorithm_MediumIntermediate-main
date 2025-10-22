Algorithm (Minimum Radio Transmitters for Hackerland):

Sort the array of house locations.

Initialize variables for the number of transmitters and an index pointer.

While there are houses left:

Place a transmitter as far to the right as possible within reach of the first uncovered house.

Move forward to the farthest house covered by this transmitter.

Move further forward while the next house is still within transmitter reach.

Repeat until all houses are covered.

Return the total number of transmitters.