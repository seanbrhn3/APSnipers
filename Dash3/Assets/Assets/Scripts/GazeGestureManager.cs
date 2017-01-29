using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class GazeGestureManager : MonoBehaviour
{
    public static GazeGestureManager Instance { get; private set; }

    // Represents the hologram that is currently being gazed at.
    public GameObject FocusedObject { get; private set; }
    public GameObject FoObject { get; private set; }
    public ParticleSystem cloud;
    public GameObject sun;
    public ParticleSystem lighting;
    public ParticleSystem snow;
    public ParticleSystem rain;
    int go = 2;
    

    //    AnimController animControl = new AnimController();

    GestureRecognizer recognizer;

    // Use this for initialization
    void Start()
    {
        Instance = this;

        // Set up a GestureRecognizer to detect Select gestures.
        recognizer = new GestureRecognizer();
        recognizer.TappedEvent += (source, tapCount, ray) =>
        {
            // Send an OnSelect message to the focused object and its ancestors.
            if (FocusedObject != null)
            {
                FocusedObject.SendMessageUpwards("OnSelect");
                string anim = SphereCommands.weather;
                print("++++++++++++++" + anim + "+++++++++++++++");

                switch (anim)
                {
                    case "Cloudy":
                        //do something
                        cloud.Play();
                        sun.SetActive(true);
                        break;
                    case "Some clouds":
                        cloud.Play();
                        sun.SetActive(true);
                        break;
                    case "Mostly cloudy":
                        print("mostlycloudy");
                        // FocusedObject.SendMessageUpwards("turnOn");
                        cloud.Play();
                        sun.SetActive(true);
   //                     double x = 0;
    //                    while (x < 10)
   //                     {
   //                         x += .01;
   //                     }
   //                     cloud.Stop();
   //                     sun.SetActive(false);
                        //CloudSunny();
                        break;
                    case "Clouds and sun":
                        print("*******************Clouds And Sun*************");
                        //               FocObject.SendMessageUpwards("turnOn");
                        cloud.Play();
                        sun.SetActive(true);
 //                       double y = 0;
//                        while (y < 100000000000000000)
  //                      {
 //                           y += .01;
 //                           print(y);
                //        }
//                        cloud.Stop();
   //                     sun.SetActive(false);

                        //CloudSunny();
                        break;

                    case "Partly cloudy":
                        cloud.Play();
                        sun.SetActive(true);
                        break;


                    case "Light fog":
                        //do something
                        cloud.Play();
                        sun.SetActive(true);
                        break;
                    case "Heavy fog":
                        cloud.Play();
                        sun.SetActive(true);
                        break;
                    case "Clear":
                        cloud.Play();
                        sun.SetActive(true);
                        break;
                    case "Light snow shower":
                        rain.Play();
                        sun.SetActive(true);
                        break;
                    default:
                        break;

                }

                anim = "";
                SphereCommands.weather = "";
                
            }
            go--;
            if (go == 0)
            {

                FoObject.SendMessageUpwards("OnSelectTwo");
                string anem = CommandTwo.weatherTwo;
                print("++++++++++++++" + anem + "+++++++++++++++");

                rain.Play();
            }
                
        };
        recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update()
    {
        // Figure out which hologram is focused this frame.
        GameObject oldFocusObject = FocusedObject;

        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            // If the raycast hit a hologram, use that as the focused object.
            FocusedObject = hitInfo.collider.gameObject;
        }
        else
        {
            // If the raycast did not hit a hologram, clear the focused object.
            FocusedObject = null;
        }

        // If the focused object changed this frame,
        // start detecting fresh gestures again.
        if (FocusedObject != oldFocusObject)
        {
            recognizer.CancelGestures();
            recognizer.StartCapturingGestures();
        }
    }
}
