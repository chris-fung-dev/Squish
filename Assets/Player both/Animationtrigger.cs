using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtrigger : MonoBehaviour
{
    public bool SquishCheck;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SquishCheck = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SquishCheck = false;
    }
}
