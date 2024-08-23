using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLock : MonoBehaviour
{
    public BlueKey purple;
    public DoubleLock LockManager;
    public GameObject Lock;
    public GameObject BlueKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            if (purple.p1HasBlueKey)
            {
                LockManager.Lock2Unlocked = true;
                Destroy(Lock);
                Destroy(BlueKey);
            }
        }
        if (other.CompareTag("Player2"))
        {
            if (purple.p2HasBlueKey)
            {
                LockManager.Lock2Unlocked = true;
                Destroy(Lock);
                Destroy(BlueKey);
            }
        }
    }
}
