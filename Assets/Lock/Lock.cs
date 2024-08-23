using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public ButtonToSpawner Button;
    public KeyFollowPlayerScript key;
    public GameObject Locks;
    public GameObject Keys;

    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player1"))
            {
                if (key.p1haskey)
                {
                    Button.NeedKey = false;
                    DeleteItemsInvolved();
                }
            }

            if (other.gameObject.CompareTag("Player2"))
            {
                if (key.p2haskey)
                {
                    Button.NeedKey = false; 
                    DeleteItemsInvolved();
                }
            }
        }

    void DeleteItemsInvolved()
    { 
        Destroy(Keys);
        Destroy(Locks);
    }
}

