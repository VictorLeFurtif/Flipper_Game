using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    public int scoreForVictoryTuto = 7000;
    public compteur cpt;
    void Update()
    {
        if (cpt.currentValueCounter >= scoreForVictoryTuto)
        {
            SceneManager.LoadScene("Victory");
            Time.timeScale = 1;
        }  
    }
}
