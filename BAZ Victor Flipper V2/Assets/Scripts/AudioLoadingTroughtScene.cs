using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoadingTroughtScene : MonoBehaviour
{
   public AudioSource audioS;
   public static AudioLoadingTroughtScene instance;
   
   public void Awake()
   {
       if (instance == null)
       {
           instance = this;
           DontDestroyOnLoad(gameObject);
       }
       else
       {
           Destroy(gameObject);
       }
   }
   
}
