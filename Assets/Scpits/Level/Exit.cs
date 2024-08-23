using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    private bool P1_Exit;
    private bool P2_Exit;
  
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Player1"))
        {
            P1_Exit = true;
            Destroy(Player1);
        }
        if (collider2D.gameObject.CompareTag("Player2"))
        {
            P2_Exit = true;
            Destroy(Player2);
        }
        
    }

    private void Update()
    {
        if (P2_Exit && P1_Exit)
        {
            NextScene();
        }
    }
    private void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
