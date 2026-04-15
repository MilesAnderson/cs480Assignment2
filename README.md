# cs480Assignment2 -- Assignment 2 for cs480

## Team members:
### Miles Anderson & Tyler Garske

## Usages:

`Dot product:`
-
    Contributed to by:

`Linear interpolation:`
- 
    Contributed to by: Miles Anderson
    The linear interpolation is used to calculate the distance between the user and the nearest enemy. The player's distance is mapped to a value between 1 and 0 using inverse lerp. This value is then used to control the emission rate of sweat particles from the player. To see the effects of this linear interpolation observe the sweat particles surrounding the players head as they get closer and farther from enemies.

`Particle effect:`
-
    Contributed to by: Miles Anderson
    The added particle effect consists of light blue spheres emitting from the players head. They are intended to resemble sweat, as if the player is scared to get too close to an enemy. The particle system is combined with the linear interpolation implementation so the sweat becomes more intense the closer the player is to an enemy. To trigger the sweat particles walk as close to an enemy as possible and then walk as far away from any enemy as possible. 

`Sound effect:`
-
    Contributed to by:

    