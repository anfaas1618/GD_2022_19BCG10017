using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public void startGame()
    {
        SceneManager.LoadScene(1);
    }

   public void startHome()
   {
       SceneManager.LoadScene(0);
   }

   public void startRetry()
   {
       SceneManager.LoadScene(1);
   }
}
