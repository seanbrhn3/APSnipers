using System.Collections;
using UnityEngine;

public class CommandTwo : MonoBehaviour
{
    //    Vector3 originalPosition;
    private string url = "http://dataservice.accuweather.com/currentconditions/v1/200?apikey=XD2AtAGKQnfVrkfXNFGzIRqYQolteQTG";
    // Use this for initialization
    string word = "";
    public static int stateOne = 1;
    public static string weatherTwo;

    //    void Start()
    //   {
    // Grab the original local position of the sphere when the app starts.
    //       originalPosition = this.transform.localPosition;
    //   }



    IEnumerator OnSelectTwo()
    {
        WWW www = new WWW(url);
        yield return www;
        int i = 0;

        while (i < www.text.Length)
        {
            //print(word += www.text[i]);
            if (www.text[i] == 'W')

            {

                int j = i++;
                j++;
                if (www.text[j] == 'e')
                {
                    while (www.text[j] != ':')
                    {
                        j++;
                    }
                    j++;
                    j++;
                    while (www.text[j] != '"')
                    {

                        word += www.text[j];

                        j++;
                    }
                    break;
                }
                else
                {
                    i++;
                }
            }
            else
            {
                i++;
            }
        }
        weatherTwo = word;
        stateOne = 2;
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    //    void OnSelect()
    //   {
    // If the sphere has no Rigidbody component, add one to enable physics.
    //       if (!this.GetComponent<Rigidbody>())
    //       {
    //          var rigidbody = this.gameObject.AddComponent<Rigidbody>();
    //          rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
    //       }
    //   }

    // Called by SpeechManager when the user says the "Reset world" command


    // Called by SpeechManager when the user says the "Drop sphere" command

}


