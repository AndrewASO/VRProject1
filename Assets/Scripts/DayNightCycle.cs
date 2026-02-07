using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    public float dayDuration = 60; //This is the duration of the day-night cycle in seconds
    public Light light; //This'll be a reference to the light source used as the "sun"
    private float rotationSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        if (light == null ) {
            light = GetComponent<Light>();
        }

        //Calculation of rotation speed: 360 degrees / day cycle duration
        rotationSpeed = 360 / dayDuration;
    }

    // Update is called once per frame
    void Update() {
        // Rotating the light around the X-axis for now at a constant speed.
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
}
