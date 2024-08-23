using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
public class OnClickLoadNext : MonoBehaviour
{
   public GameObject Controls;
   public void NextLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void ExitGame()
   {
      Application.Quit();
   }

   public void ControlsOn()
   {
      Controls.SetActive(true);
   }


}
