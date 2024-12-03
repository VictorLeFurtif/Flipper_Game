using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinBall : MonoBehaviour
{
    public GameObject[] skin;

    void Start()
    {
        Debug.Log("Start");
        int skinIndex = PlayerPrefs.GetInt("skin");
        foreach (GameObject VARIABLE in skin)
        {
            VARIABLE.SetActive(false);
        }
        Debug.Log(PlayerPrefs.GetInt("skin"));
        skin[skinIndex].SetActive(true); 
    }
}