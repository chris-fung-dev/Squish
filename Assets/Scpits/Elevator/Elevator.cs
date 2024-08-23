using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Elevator : MonoBehaviour
{
    public RopeCounter ropeamount;
    public GameObject Player1;
    public GameObject Player2;
    public int howmanyleft;
    public Animator anim;
    //Color bool
    public bool ShouldBeYellow;
    public bool ShouldBeRed;
    public int Speed;
    public bool MoveUpis;
    public GameObject Rope;
    public GameObject timer;
    public bool timerStop;
    public AudioSource ding;
    public bool dinger;
    public bool played;
    public AudioSource ElevatorSounds;
    public bool playElevatorSound;
    public bool played_ElevatorSounds;
   private void OnCollisionEnter2D(Collision2D other)
   {
       if (ropeamount.Ropecollected > 0f)
       {
           if (other.gameObject.CompareTag("Player1"))
           {
               Destroy(Player1);
               ++howmanyleft;
           }

           if (other.gameObject.CompareTag("Player2"))
           {
               Destroy(Player2);
               ++howmanyleft;
           }
       }
       
   }

   private void Update()
   {
       if (howmanyleft >= 2)
       {
           Destroy(Player1);
           Destroy(Player2);
           playElevatorSound = true;
           anim.SetBool("Transition", true);
           anim.SetBool("Open", false);
           Invoke("MoveUp", 1f);
           Invoke("Nextlevel",4f);
       }

       if (playElevatorSound && !played_ElevatorSounds)
       {
           ElevatorSounds.Play();
           played_ElevatorSounds = true;
           Invoke("StopSound_Elevator", ElevatorSounds.clip.length);
       }
      
       if (dinger && !played)
       {
           ding.Play();
           played = true; // Set played to true to indicate the sound has been played
           Invoke("StopSound", ding.clip.length);
       }
   }
   

   
    
   private void Nextlevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void MoveUp()
   {
       MoveUpis = true;
   }

   private void FixedUpdate()
   {
       ColorChanger();
       if (ropeamount.Ropecollected > 0f)
       {
           anim.SetBool("Open", true);
           
           Rope.SetActive(true);
           timer.SetActive(false);
           timerStop = true;
           dinger = true;
       }

       if (MoveUpis)
       {
           transform.Translate(Vector3.up * Speed * Time.deltaTime);
       }
   }

   private void ColorChanger()
   {
     
       if (ShouldBeYellow)
       {
           anim.SetBool("Yellow", true);
       }
       if (ShouldBeRed)
       {
           anim.SetBool("Yellow", false);
           anim.SetBool("Red", true);
       }
   }
   private void StopSound()
   {
       ding.Stop();
   }

   private void StopSound_Elevator()
   {
       ElevatorSounds.Stop();
   }
}
