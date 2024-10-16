using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_menu_back : MonoBehaviour
{
    public void LoadsceneByName()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        
    }

    
    
}