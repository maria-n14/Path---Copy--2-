
using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour
{
    public static bool objectDestroyed=false;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        objectDestroyed = true;

    }
}

//racemanager = GameObject.Find("Racemanager").GetComponent<RaceManager>();