using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoove : MonoBehaviour
{
    public LoadSceneGame lSgame;
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

}
