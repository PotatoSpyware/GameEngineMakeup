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
https://gamedev.net/blogs/entry/2277680-factory-design-pattern-in-unity/?__cf_chl_tk=ZCdM9Qh_PiVQ5anuUr5N_kuGG6awdysRrB8Heb5AWvg-1793923747-1.0.1.1-l1mmjxuNh5YVxsAJRJxe6ncBHT.VU8Xi8OvPCFlWDW4
Used to double check my execution of a factory pattern.