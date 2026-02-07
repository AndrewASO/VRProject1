//Maybe at some point in time change the rotate to be public ?
//Public x,y,z so I can change it in the future for different things because right now,
//I'm creating a different .cs for saw rotation when I could probably do it in this Rotator
//class if I merely changed the inputs to be public

using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime );
    }
}
