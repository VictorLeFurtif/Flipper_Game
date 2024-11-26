using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCameraSkin : MonoBehaviour
{
    public Animation animCamToskin;

    public void CameraToSkinAnim()
    {
        animCamToskin.Play("CameraToSkin");
        Debug.Log("CameraPlay");
    }
}
