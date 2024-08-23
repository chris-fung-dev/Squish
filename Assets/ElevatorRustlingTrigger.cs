using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorRustlingTrigger : MonoBehaviour
{
    public AudioSource ElevatorSounds;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag== "Elevator")
        {
            ElevatorSounds.Play();
            Debug.Log("Hell");
        }
    }
}
