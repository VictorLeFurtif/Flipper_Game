using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
   
   public GameObject gVolume;
   public GameObject gVolumeMenu;
   public GameObject menuButton;
   public bool menuInAction = false;
  
   public void OpenCloseMenu()
   {
      if (menuInAction == false)
      {
         gVolume.SetActive(false);
         gVolumeMenu.SetActive(true);
         menuInAction = true;
         menuButton.SetActive(true);
         Time.timeScale = 0;
      }
      else 
      {
         gVolume.SetActive(true);
         gVolumeMenu.SetActive(false);
         menuInAction = false;
         menuButton.SetActive(false);
         Time.timeScale = 1;
      }
     
   }
}
