using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleLock : MonoBehaviour
{
    public PurpleKey purple;
    public DoubleLock LockManager;
    public GameObject Lock;
    public GameObject PurpleKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            if (purple.p1PurpleKey)
            {
                LockManager.Lock1Unlocked = true;
                Destroy(Lock);
                Destroy(PurpleKey);
            }
        }
        if (other.CompareTag("Player2"))
        {
            if (purple.p2PurpleKey)
            {
                LockManager.Lock1Unlocked = true;
                Destroy(Lock);
                Destroy(PurpleKey);
            }
        }
    }
}
