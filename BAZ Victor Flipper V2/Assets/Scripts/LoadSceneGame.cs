using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneGame : MonoBehaviour
{
   public void LoadsceneByName()
   {
      SceneManager.LoadScene("Game");
   }

   public void LoadNextInBuild()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
    
}
