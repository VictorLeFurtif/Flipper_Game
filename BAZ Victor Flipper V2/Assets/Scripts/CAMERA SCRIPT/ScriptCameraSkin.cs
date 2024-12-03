using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCameraSkin : MonoBehaviour
{
    public Animation animCamToskin;
    public GameObject[] buttonSecondZone;
    
    public void CameraToSkinAnim()
    {
        animCamToskin.Play("CameraToSkin");
        StartCoroutine(WaitToMakeButtonAppear());

    }

    IEnumerator WaitToMakeButtonAppear()
    {
        yield return new WaitForSeconds(1);
        foreach (var i in buttonSecondZone)
        {
            i.SetActive(true);
        }
    }
}
