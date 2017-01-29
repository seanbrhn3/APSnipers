using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAllAnim : MonoBehaviour {
    public ParticleSystem cloud;
    public GameObject sun;
    public ParticleSystem lighting;
    public ParticleSystem snow;
    public ParticleSystem rain;

    // Use this for initialization
    void Start () {
        cloud.Stop();
        sun.SetActive(false);
        lighting.Stop();
        snow.Stop();
        rain.Stop();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
