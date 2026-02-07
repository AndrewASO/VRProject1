//Got the bomb sfx from https://assetstore.unity.com/packages/audio/sound-fx/retro-noisy-explosion-sound-pack-lite-69305


using UnityEngine;

public class Bomb : MonoBehaviour {

    public Transform player;
    public AudioClip explosionSound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    //This function is for when a player object collides with the bomb 
    private void OnCollisionEnter(Collision collision) {
        
        if ( collision.gameObject.CompareTag("Player")) {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position ); // Plays the audio sound of the explosion occurring
            Destroy(gameObject); //Bomb disappears as it blows up
        }
    }
}
