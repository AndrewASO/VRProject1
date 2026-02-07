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
