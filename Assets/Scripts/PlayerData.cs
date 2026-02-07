/**
This was created to maintain constant player data. When going from scene 1 to scene 2, then there would be a loss of data
relating to the player information because they're two different objects. By initializing the player obj with the PlayerData.cs,
then the information can be conserved as this is a static obj. It only needs to be refreshed whenever the game is restarted, or 
updated before the player goes to another scene.
*/

using UnityEngine;

public static class PlayerData{

    public static int HP = 3;
    public static int Score = 0;
}
