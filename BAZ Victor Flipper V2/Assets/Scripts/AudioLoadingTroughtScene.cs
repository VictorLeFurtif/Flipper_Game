using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoadingTroughtScene : MonoBehaviour
{
   public AudioSource audioS;

   public void Awake()
   {
	   DontDestroyOnLoad(gameObject);
   }
   
}
