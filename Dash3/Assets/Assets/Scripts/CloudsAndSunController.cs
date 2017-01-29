using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsAndSunController : MonoBehaviour {

   

    void turnOn()
    {
        //    gameObject.SetActive(true);
        this.GetComponent<ParticleSystem>().Play();
        print("not null");
    }

}
