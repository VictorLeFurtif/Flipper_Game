using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public GameObject textSkinDone;
    public GameObject textSkinNotDone;

   

    public void SkinChangerTomato()
    {
        if (PlayerPrefs.GetInt("Max Score") >= 0 )
        {
            PlayerPrefs.SetInt("skin", 0);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            StartCoroutine(SkinEquipped());
        }
        else
        {
            StartCoroutine(SkinNotEquipped());
        }
    }
    public void SkinChangerPeach()
    {
        if (PlayerPrefs.GetInt("Max Score") >= 10000 )
        {
            PlayerPrefs.SetInt("skin", 1);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            StartCoroutine(SkinEquipped());
        }
        else
        {
            StartCoroutine(SkinNotEquipped());
        }
    }
    public void SkinChangerApple()
    {
        if (PlayerPrefs.GetInt("Max Score") >= 20000 )
        {
            PlayerPrefs.SetInt("skin", 2);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            StartCoroutine(SkinEquipped());
        }
        else
        {
            StartCoroutine(SkinNotEquipped());
        }
    }
    public void SkinChangerDonut()
    {
        if (PlayerPrefs.GetInt("Max Score") >= 30000 )
        {
            PlayerPrefs.SetInt("skin", 3);
            Debug.Log(PlayerPrefs.GetInt("skin"));
            StartCoroutine(SkinEquipped());
        }
        else
        {
            StartCoroutine(SkinNotEquipped());
        }
    }

    IEnumerator SkinEquipped()
    {
        textSkinDone.SetActive(true);
        yield return new WaitForSeconds(1);
        textSkinDone.SetActive(false);
    }
    
    IEnumerator SkinNotEquipped()
    {
        textSkinNotDone.SetActive(true);
        yield return new WaitForSeconds(1);
        textSkinNotDone.SetActive(false);
    }
}
