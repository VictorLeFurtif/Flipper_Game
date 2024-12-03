using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneGame : MonoBehaviour
{
   
   public void LoadsceneGame()
   {
      SceneManager.LoadScene("Game");
      Debug.Log("Test");
      Time.timeScale = 1;
   }
   
   public void LoadsMenuHelp()
   {
      SceneManager.LoadScene("MenuHelpNew");
      Time.timeScale = 1;
   }
   public void LoadsMenu()
   {
      SceneManager.LoadScene("MenuNew");
      Time.timeScale = 1;
        
   }
   
   public void QuittButton()
   {
      Application.Quit();
   }

   public void LoadSceneSkin()
   {
      SceneManager.LoadScene("SkinB");
      Time.timeScale = 1;
   }
   
}
