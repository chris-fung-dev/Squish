using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public bool OutOfbounds;
    public AudioSource error_soundeffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        OutOfbounds = true;
        error_soundeffect.Play();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        OutOfbounds = false;
        error_soundeffect.Play();
    }
}
