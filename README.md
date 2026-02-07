
This is a Unity game for testing features.
The game has the following features:

- Dynamic Enemies
- Static Traps
- Dynamic Traps
- Score System
- Health tracking
- WASD & Jump movement
- Collisions with objects, enemies, and traps
- Solid & bouncy surfaces
- Scene Changes
- Storage of information through multiple scenes
- Ability to build a .exe from files in github
- Day/Night Cycle
- Audio for one trap currently
- Camera following player movement



Features I wish to refine / implement

- For the dynamic traps, they will go askew when colliding against an object other than a flat wall so will be looking into how to keep them consistent
- Day/Night cycle works currently but will be looking into more dynamic lighting. Along with looking into skyboxes and sun sources
- Implementing better camera angles for the user to observe the player model
- Implementing sfx for other enemies & traps along with background music
- Optimization of models and code
- Expanding upon the 1st & 2nd level
- Learning more on how to properly implement vfx
- Implementing abilities for enemies
- Implementing powerups for player




Personally, I'm happy with the process of learning the different materials and importing 3D assets into Unity and getting them functional with the scenes. A lot of the beginning code, I was following
from a Unity tutorial but I began implementing more of my own code for the 2nd scene and experimenting with things like bouncy surfaces. The bouncy balls were something interesting to work with and testing
out the right bounciness level and how to even make bouncy material and put it onto a 3D object. <br>

Day/Night cycle I worked on by having 2 directional lights: 1 for sun, 1 for moon. I then had the adaptive probe volume, so I could begin generating the lighting and had 1 scenario for day and another scenario 
for night by turning off / on the respective directional lights. After that, I used a blending script to change it from the day scenario to night scenario then back to the day scenario. While it works for now as
a rudimentary day/night system, I'd like to begin working on rotating skyboxes and a sun object. Ideally, I'd like to further refine the idea into one where I can have a dynamic skybox along with a rotating sun, 
then the moon can come up and shift the color from the yellow/orange hue of the sun to more of a blue / black for the moon. <br>

I didn't get to experiment much with independent light systems of the directional lights such as lamps, in future tests I'd like to experiment with those and see how they function in generated lighting. <br>

The code isn't superb and more thrown together but it functions for now and overtime, I'll begin optimizing it and removing the unnecessary parts or refining the functions better. <br>

Camera positioning was something I had trouble with as if I had the player inside of a closed box, then at certain areas it would have the player be blocked by the walls. I may change it to 1st pov or have the camera 
follow the player closer. I believe the eagle eyes view only works over an open terrain and isn't good for closed environments or tight quarters. <br>

Baking the ground is something I'd like to further refine and see if there's manual editing of it rather than relying on a general baking process for it, because as I was placing obstacles there were some issues with
how it went over and I'd like to refine it making it more precise. <br>

More sfx should've been added for different objects like the saws or jumping onto the bouncy balls. I believe slime sounds when jumping onto the bouncy balls, or saws whirring, or a bonk noise when colliding
into a wall could be more immersive along with having background sfx.
