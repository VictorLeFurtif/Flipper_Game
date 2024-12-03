using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaxScoreSkin : MonoBehaviour
{
    
    public GameObject maxScoreText;
    void Start()
    {
        int scoreFinal = PlayerPrefs.GetInt("Max Score");
        maxScoreText.GetComponent<TMP_Text>().text = ""+ scoreFinal;
    }
    
}
