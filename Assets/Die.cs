using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public PlayerRespawn Respawn;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Respawn.TelportToRepsawn();
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            Respawn.TelportToRepsawn(); 
        }
    }
  
}
