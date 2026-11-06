# INFR 3110 Make Up Assignment
---
### Name : Sean Russett
### Student Number : 100963434
---
# Object Oriented Programming
---
### Description
<!-- Briefly describe the classes, their relationships, and how object-oriented
programming principles are demonstrated in your implementation. -->
## UML Diagram
<!-- Attach your UML diagram here -->
---
# Singleton Pattern
---
### Purpose
I used a singleton for the player controller, and it is appropriate to use it for this 
as having multiple player controllers could cause gameplay issues.
### Implementation
I implemented the singleton pattern on the player controller by creating a static 
reference that can be used by other scripts, as well as having the script check if it
is the only instance of itself on awake.

# Factory Pattern
---
### Purpose
I used the factory pattern to spawn the tail and apple pieces, the factory pattern is 
appropriate for this as I can now use the same script for spawning either piece.
### Implementation
The factory pattern is implemented by supplying a single factory script with the 
multiple game objects that will be needed to be spawned at different times, and 
providing it with a method that spawns the required object using a string passed to it.

# References
---
<!-- Identify sources used to create any gameplay logic or programming pattern
implementations. -->