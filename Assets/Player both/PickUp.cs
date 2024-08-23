using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   public GameObject Rope;
   private RopeCounter conter;

   private void Start()
   {
      conter = GameObject.FindWithTag("Counter").GetComponent<RopeCounter>();
   }

   void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Player1"))
      {
         conter.RopeCollected();
         Destroy(gameObject);
      }
      if (other.gameObject.CompareTag("Player2"))
      {
         conter.RopeCollected();
         Destroy(gameObject);
      }
   }
}
