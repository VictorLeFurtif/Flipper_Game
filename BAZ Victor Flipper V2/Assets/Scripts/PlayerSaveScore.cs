using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaveScore : MonoBehaviour
{
   public int score;
   public Compteur cpt;
   public void WhenDie()
   {
      if (PlayerPrefs.GetInt("Max Score") < cpt.currentValueCounter)
      {
         score = cpt.currentValueCounter;
         PlayerPrefs.SetInt("Max Score", score);
      }
      else
      {
         score = PlayerPrefs.GetInt("Max Score");
      }
   }
}
