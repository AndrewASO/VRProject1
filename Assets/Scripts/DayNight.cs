//This code is from Unity's website for handling Blending of Light renders
//https://docs.unity3d.com/6000.0/Documentation/Manual/urp/probevolumes-bakedifferentlightingsetups.html
//Might need to change some of the public variables to private later on but I'll leave it like this for now 
//since its more of an optional thing and getting this started for now. Think almost all of them could be privated,
//would just need to hard code in scenario1 & 2, so those may be left public to copy & paste in other projects 
//Figured out the concept of multiple scenarios from this video as well
//https://www.youtube.com/watch?v=oL6oGMkhJwQ

using UnityEngine;

public class DayNight : MonoBehaviour {

    UnityEngine.Rendering.ProbeReferenceVolume probeRefVolume;
    public string scenario1;
    public string scenario2;

    public bool playAuto = true;
    [Min(0.1f) ] public float cycleDuration = 10f; //Time for a full cycle from 0 blending factor to 1 to 0

    [Range(0, 1) ] public float blendingFactor = 0.5f;
    private float timer = 0f;
    
    [Min(1)] public int numberOfCellsBlendedPerFrame = 10;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        probeRefVolume = UnityEngine.Rendering.ProbeReferenceVolume.instance;
        probeRefVolume.lightingScenario = scenario1;
        probeRefVolume.numberOfCellsBlendedPerFrame = numberOfCellsBlendedPerFrame;
    }

    // Update is called once per frame
    void Update() {

        //Update the timer
        timer += Time.deltaTime;

        //Calculate blending factor using PingPong
        blendingFactor = Mathf.PingPong(timer / (cycleDuration * 0.5f), 1f);

        //Apply Blending of scenario 2 to scenario 1
        probeRefVolume.BlendLightingScenario(scenario2, blendingFactor );
    }

    //Might add optional func to set time of day later
}
