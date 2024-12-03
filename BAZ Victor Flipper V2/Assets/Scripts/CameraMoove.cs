using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoove : MonoBehaviour
{
    
    public Animation anim;
    public GameObject canvas;
    

    public void BlackDeplacement()
    {
        anim.Play();
        canvas.SetActive(false);
    }

    public void CanvasActivate()
    {
        canvas.SetActive(true);
    }
    
    // Bug m'empêche d'utiliser la methode BlackDeplacement jsp pk

    public void BlackDeplacementForSkin()
    {
        anim.Play("BlackFondu Load Skin");
        canvas.SetActive(false);
    }

}
