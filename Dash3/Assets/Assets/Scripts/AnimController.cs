using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    //    public GameObject FocObject { get; private set; }
    GameObject clouds;
    GameObject sun;
    GameObject lighting;
    GameObject snow;
    GameObject rain;

    public static GameObject FoObject { get; private set; }

    public static void runAnim(string text)
    {
        switch (text)
        {
            case "Cloudy":
                //do something
                break;
            case "Some clouds":
                break;
            case "Mostly cloudy":
                FoObject.SendMessageUpwards("turnOn");
                //CloudSunny();
                break;
            case "Clouds and sun":
                print("*******************Clouds And Sun*************");
                //               FocObject.SendMessageUpwards("turnOn");


                //CloudSunny();
                break;

            case "Partly cloudy":
                break;


            case "Light fog":
                //do something
                break;
            case "Heavy fog":
                break;
            case "Clear":
                break;
            case "Light snow shower":
                break;
            default:
                break;

        }
        SphereCommands.weather = "";
    }


    void CloudSunny()
    {
        clouds = GameObject.FindWithTag("clouds").gameObject;
        clouds.SetActive(true);
        


        if(clouds == null)
        {
            print("Its null!!!!!!!!!!");
        }


        float x = 0;
        while(x < 10)
        {
            x += .01f;
            print(x);
        }
    }
}
