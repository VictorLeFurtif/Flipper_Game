using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class compteur : MonoBehaviour

{
    public int currentValueCounter = 0;
    public GameObject scoreText;
    
    
    
    void Start()
    {
        scoreText.GetComponent<TMP_Text>().text = ""+currentValueCounter;
    }

    public void UpdateScore(int points)
    {
        currentValueCounter = currentValueCounter + points;
        scoreText.GetComponent<TMP_Text>().text = ""+currentValueCounter;
    }
    
}
