using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Compteur : MonoBehaviour

{
    public int currentValueCounter = 0;
    public GameObject scoreText;
    public GameObject secondScoreText;
    
    
    
    void Start()
    {
        scoreText.GetComponent<TMP_Text>().text = ""+currentValueCounter;
        secondScoreText.GetComponent<TMP_Text>().text = ""+currentValueCounter;
    }

    public void UpdateScore(int points)
    {
        currentValueCounter = currentValueCounter + points;
        scoreText.GetComponent<TMP_Text>().text = ""+currentValueCounter;
        secondScoreText.GetComponent<TMP_Text>().text = ""+currentValueCounter;
    }
    
}
