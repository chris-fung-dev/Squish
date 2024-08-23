using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoubleLock : MonoBehaviour
{
    public bool Lock1Unlocked;
    public bool Lock2Unlocked;
    public ButtonToSpawner Button;
    private void Update()
    {
        if (Lock1Unlocked)
        {
            if (Lock2Unlocked)
            {
                Button.NeedKey = false;
            }
        }
    }
}
