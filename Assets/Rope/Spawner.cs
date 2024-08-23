using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Rope;
    // Start is called before the first frame update
    private void Start()
    {
        Instantiate(Rope, transform.position, transform.rotation);
    }


}
