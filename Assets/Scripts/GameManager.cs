/**
Because the player gameobj is destroyed when there is a loss then this was created. Could've been either to ghost the player gameobj,
so the entity itself still exists so functions can still work inside of it or this. Decided to have a GameManager if other functions 
are necessary in the future rather than tying everything to the PlayerController.cs file. Currently its only used for restarting
the game whenever the player obj is destroyed.
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject); //Prevents duplicates if scene reloads
        }
    }


    // Update is called once per frame
    void Update() {
        // This ignores Action Maps and just looks directly at the hardware
        if (Keyboard.current != null && Keyboard.current.rKey.wasPressedThisFrame) {
            //Might want to start PlayerData anew but unsure how because I noticed it updates when going from Wipeout Scene to 
            //Minigame scene and saves it so despite doing a total reset the hp / score doesn't reset as well so hardcoding it for now.
            PlayerData.HP = 3;
            PlayerData.Score = 0;
            SceneManager.LoadScene("Wipeout");
        }
    }
}
