using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevelLoadScene : MonoBehaviour
{
    public void LoadsceneTuto()
    {
        SceneManager.LoadScene("Tuto");
        Time.timeScale = 1;
    }
    
    public void LoadsceneLvl1()
    {
        SceneManager.LoadScene("Lvl1");
        Time.timeScale = 1;
    }
    
    public void LoadsceneLvl2()
    {
        SceneManager.LoadScene("Lvl2");
        Time.timeScale = 1;
    }
}
