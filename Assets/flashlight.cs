using UnityEngine;

using System.Collections;




public class flashlight : MonoBehaviour

{

    bool flashlightOn = false;

    public Light light;
   // GameObject.Find("PLayer").GetComponent<Collisions>();
    void start()
    {
        light = GetComponent<Light>();
       // flashlight = GameObject.Find("flashlight");
    }

    void Update()
    {
       // if (objectDestroyed = true) 
        //{
            if (Input.GetKeyDown("f"))
            {
                flashlightOn = !flashlightOn;
            }
            light.intensity = flashlightOn ? 3 : 0;
       // }
    }
}
