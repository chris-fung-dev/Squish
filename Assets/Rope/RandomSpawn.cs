using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;
    private int randomNumber;

    private void Start()
    {
        int randomNumber = Random.Range(1, 4);
        Debug.Log("Generated Random Number: " + randomNumber);
        if (randomNumber == 1)
        {
            Spawner1.SetActive(true);
        }

        if (randomNumber == 2)
        {
            Spawner2.SetActive(true);
        }

        if (randomNumber == 3)
        {
            Spawner3.SetActive(true);
        }

        if (randomNumber == 4)
        {
            Spawner4.SetActive(true);
        }
    }
}