using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject player;

    public GameObject Respawn;
    public OutofBounds bound2;
    public OutofBounds bound1;


    // Update is called once per frame
    void Update()
    {
        if (bound2.OutOfbounds || bound1.OutOfbounds )
        {
            TelportToRepsawn();
        }
      
    }

    public void TelportToRepsawn()
    {
        player.transform.position = Respawn.transform.position;  
    }
}
