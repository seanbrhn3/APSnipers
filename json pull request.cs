using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Web.Helpers;

public class NewBehaviourScript : MonoBehaviour {
    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://dataservice.accuweather.com/currentconditions/v1/300?apikey=XD2AtAGKQnfVrkfXNFGzIRqYQolteQTG"))
        {
            yield return www.Send();

            if (www.isError)
            {
                Debug.Log(www.error);
            }
            else
            {
                // Show results as text
                dynamic data = JsonConvert.DeserializeObject(www.downloadHandler.json);
                // Or retrieve results as binary data
                string text = data.WheatherText;

                switch (text) {
                    case "Cloudy":
                        //do something
                        Console.WriteLine("Case 1");
                    case "Some clouds":
                        Console.WriteLine("Case 1");
                    case "Mostly cloudy":
                        Console.WriteLine("Case 1");
                    case "Partly cloudy":
                        Console.WriteLine("Case 1");
                        break;

               
                    case "Light fog":
                    //do something
                    case "Heavy fog":
                        Console.WriteLine("Case 1");
                        break;
                    case "Clear":
                        Console.WriteLine("Case 1");
                        break;
                    case "Light snow shower":
                        Console.WriteLine("Case 1");
                        break;
                    default:
                        Console.WriteLine("Case 1");
                        break;
                    
                }
            }
        }
    }
}


