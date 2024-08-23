 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class RopeCounter : MonoBehaviour
{
    public int Ropecollected;
    public Text RopeNumber;
    // Start is called before the first frame update

   public void RopeCollected()
   {
       ++Ropecollected;
   }

   private void Update()
   {
       RopeNumber.text = Ropecollected.ToString("0");
   }
}
