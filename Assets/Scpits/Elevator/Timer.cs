using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timertext;
    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;
    public Elevator Elevatorscript;
    public GameObject RedScreen;
    public AudioSource alarm;
    public bool ShouldPlay;
    public bool HasPlayed;
    public RopeCounter ropeamount;
    private bool Should_StartAlarm = true;
    private void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        timertext.text = currentTime.ToString("0.00");
       
        
        if (currentTime <= 20)
        {
            Elevatorscript.ShouldBeYellow = true;
        }
        
        if (currentTime <= 10)
        {
            Elevatorscript.ShouldBeYellow = false;
            Elevatorscript.ShouldBeRed = true;
        }
        
        if (currentTime <= 0f)
        {
            if (Elevatorscript.timerStop == false)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }

        if (currentTime <= 5)
        {
            if (Should_StartAlarm){
                RedScreen.SetActive(true);
            ShouldPlay = true;
            if (ShouldPlay && !HasPlayed)
            {
                alarm.Play();
                HasPlayed = true;
                Invoke("StopSound", alarm.clip.length);
            }
            }
        }

        if (ropeamount.Ropecollected > 0)
        {
           AlarmOff();
        }
    }
    private void StopSound()
    {
        alarm.Stop();
    }

    private void AlarmOff()
    {
        Should_StartAlarm = false;
        alarm.Stop();
        RedScreen.SetActive(false);
    }
    
}
