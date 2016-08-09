using UnityEngine; 
using System.Collections; 
[RequireComponent(typeof(AudioSource))] 

 
public class Footsteps : MonoBehaviour
{

 
   AudioSource footstepSound;

    // Use this for initialization 	
    void Start()
    { 
                footstepSound = gameObject.GetComponent<AudioSource>();
         } 
	 
// Update is called once per frame 
void Update()
    {
                 if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                    {
                       footstepSound.Play();
                    }
               else if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
                   {
                     footstepSound.Stop();
                   }
            } 
}
