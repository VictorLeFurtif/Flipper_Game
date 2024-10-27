using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneGame : MonoBehaviour
{
   public void LoadsceneByName()
   {
      SceneManager.LoadScene("Tuto");
      Time.timeScale = 1;
   }

   
    
}
