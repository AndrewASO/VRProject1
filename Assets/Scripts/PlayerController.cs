//Saw how to do this and some of the other portions of the code from the tutorial
//https://learn.unity.com/course/roll-a-ball?version=6.3

using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public float jumpForce = 5;
    public int health;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
    public GameObject winTextObject;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int score;
    private bool isGrounded = true; //This is to check if the player is grounded and if so enabling them the ability to jump


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;

        SetScoreText();
        winTextObject.SetActive(false);

        health = PlayerData.HP;
        score = PlayerData.Score;
        
    }

    void Update() {

        if( transform.position.y <= -10) {
            health = 0;
        }

        //Updates healthText to display the new health
        SetHealthText();        
    }

    //This is a function that'll change the x & y coordinates of the player model depending on the wasd input of the user
    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    //This is a function that'll allow a player to jump when grounded
    void OnJump(InputValue jumpValue) {
        if( isGrounded && jumpValue.isPressed ) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    //Check to see if the player on the ground
    void OnCollisionStay(Collision collision) {
        //Check if the player is colliding with something below it 
        foreach( ContactPoint contact in collision.contacts ) {
            if( Vector3.Dot(contact.normal, Vector3.up) > 0.5f) {
                isGrounded = true;
                break;
            }
        }
    }

    //This is the score text displayed in the top left for the user to see how many points they have
    void SetScoreText() {
        scoreText.text = "Score: " + score.ToString();

        if (score >= 10) {
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy") );
        }
    }

    //This sets the health left for the healthText
    void SetHealthText() {
        healthText.text = "Health: " + health.ToString();

        //Maybe set the health check condition into SetHealthText ? Gets checked anyways

        if(health == 0) {
            //Destroys the current game object (player)
            Destroy(gameObject);

            //Updates the winText to display a lose screen
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose! \n Press R to restart";
        }
    }

    //This updates everything after all the other updates go through
    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    //This function is for when the player interacts with the enemy object
    private void OnCollisionEnter(Collision collision){

        //Prob change this to be an or later, no need for an else if, something like "Enemy" || "Bomb" could suffice as there's
        //no inherent difference to them right now as both will only cause an hp drop of 1.
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Saw") || collision.gameObject.CompareTag("Bomb") ) {
            health--;
        }

        //Updates healthText to display the new health
        SetHealthText();

        if( collision.gameObject.CompareTag("Level1End")) {

            PlayerData.HP = health;
            PlayerData.Score = score;
            SceneManager.LoadScene("Minigame");
            //SceneManager.UnloadScene.Async("Wipeout");
        }
    }

    //This function is for when the player collides with any objects
    private void OnTriggerEnter(Collider other) {

        //Checks if the object has the tag PickUp and if it does then it sets the active state to false
        if(other.gameObject.CompareTag("PickUp") ){
            other.gameObject.SetActive(false);
            score++;

            SetScoreText();
        }
    }

    /** Thinking about using this to transfer player data but will try static variable first
    private void Awake() {
        object.DontDestroyOnLoad();
    }
    */

    public int ReturnScore() {
        return score;
    }
}
