using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    
    public void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("Max Score"));
    }

    public void SkinChangerTomato()
    {
        if (PlayerPrefs.GetInt("Max Score") > 0 )
        {
            PlayerPrefs.SetInt("skin", 0);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            
        }
    }
    public void SkinChangerPeach()
    {
        if (PlayerPrefs.GetInt("Max Score") > 10000 )
        {
            PlayerPrefs.SetInt("skin", 1);
            Debug.Log(PlayerPrefs.GetInt("skin"));
        }
    }
    public void SkinChangerApple()
    {
        if (PlayerPrefs.GetInt("Max Score") > 20000 )
        {
            PlayerPrefs.SetInt("skin", 2);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            
        }
    }
    public void SkinChangerDonut()
    {
        if (PlayerPrefs.GetInt("Max Score") > 30000 )
        {
            PlayerPrefs.SetInt("skin", 3);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            
        }
    }
}
