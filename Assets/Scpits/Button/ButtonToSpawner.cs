using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToSpawner : MonoBehaviour
{
    public GameObject Spawner;
    public Animator anim;
    public bool NeedKey;
    public AudioSource click;
    private void Start()
    {
        if (NeedKey)
        {
            anim.SetBool("NeedKeyanimation", true);
        }
        
    }

    void Update()
    {
        if (NeedKey == false)
        {
            anim.SetBool("NeedKeyanimation", false); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (NeedKey == false)
        {
            if (other.gameObject.CompareTag("Player1"))
            {

                Spawner.SetActive(true);
                anim.SetBool("Pressedanimation", true);
                click.Play();
            }

            if (other.gameObject.CompareTag("Player2"))
            {
                Spawner.SetActive(true);
                anim.SetBool("Pressedanimation", true);
                click.Play();
            }
        }
    }

}
