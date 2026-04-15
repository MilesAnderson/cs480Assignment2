# cs480Assignment2 -- Assignment 2 for cs480

## Team members:
### Miles Anderson & Tyler Garske

## Additions/Usages:

`Dot product:`
- I used dot product to detect whether John Lemon is facing the showering ghost across from the spawn and then subsequently trigger a special shower audio for the ghost. Computed dot product was compared against specific thresholds so that the shower sound was only activated when John Lemon is close enough + looking toward it. This was the intention for the more directional interaction rather than only the distance. I felt this was important because it didn't seem realistic to be able to trigger the audio by looking at the ghost through the neighboring walls which I came across during testing.
    - Contributed to by: Tyler Garske

`Linear interpolation:`
- The linear interpolation is used to calculate the distance between the user and the nearest enemy. 
    The player's distance is mapped to a value between 1 and 0 using inverse lerp. This value is then 
    used to control the emission rate of sweat particles from the player. To see the effects of this 
    linear interpolation, observe the sweat particles surrounding the player's head as they get closer 
    and farther from enemies.
    - Contributed to by: Miles Anderson

`Particle effect:`
- The added particle effect consists of light blue spheres emitting from the player's head. They are 
    intended to resemble sweat, as if the player is scared to get too close to an enemy. The particle 
    system is combined with the linear interpolation implementation, so the sweat becomes more intense 
    the closer the player is to an enemy. To trigger the sweat particles, walk as close to an enemy as 
    possible and then walk as far away from any enemy as possible. 
    - Contributed to by: Miles Anderson

`Sound effect:`
- Added sound effects for the shower area opposite to the spawnpoint and the grandfather clock that comes after rounding the dining table near the end hallway. The shower trigger uses distance and facing checks using the dot product to trigger and stop the audio. Tried best to limit the space of audio to just the bathroom + make it unable to be triggered through walls. The (spooky) grandfather clock audio trigger plays when John Lemon walks through the designated zone and can be configured to be EE-esque (easter egg) requiring the shower audio to be triggered first (currently un-checked in setup).
    - Contributed to by: Tyler Garske

    
