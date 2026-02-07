using UnityEngine;

public class SawRotation : MonoBehaviour {

    public bool xMovement = false;
    public bool zMovement = false;
    public float xSpeed = 0.5f;
    public float zSpeed = 0.5f;



    // Update is called once per frame
    void Update() {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime );

        Vector3 currentPosition = transform.position;

        //The movement of the saw along the x-axis / z-axis depending on the bool
        if(xMovement) {
            currentPosition.x += xSpeed * Time.deltaTime;
        }

        if(zMovement) {
            currentPosition.z += zSpeed * Time.deltaTime;
        }

        transform.position = currentPosition;
    }

    //This function is for when the saw interacts with a wall
    //This'll flip the direction in which x / z its moving in, so if the saw was moving positive x
    //then it'll flip to negative x once it hits a wall and the same for the z-axis if its moving along it.
    private void OnCollisionEnter(Collision collision) {
        if (xMovement) {
            xSpeed *= -1;
        }
        if (zMovement) {
            zSpeed *= -1;
        }
    }
}
