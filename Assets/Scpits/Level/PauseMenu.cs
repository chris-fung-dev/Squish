using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{ 
    public GameObject pause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }
}

    public void Pause(InputAction.CallbackContext context)
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Startscreen()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        Application.Quit();
        
    }
}
