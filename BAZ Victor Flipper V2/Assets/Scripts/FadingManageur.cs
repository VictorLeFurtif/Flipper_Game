using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingManageur : MonoBehaviour
{
    [SerializeField] Fondu fondu;
    [SerializeField] LoadSceneGame lmb;
    public void FadeIn()
    {
        fondu.Fade();
        StartCoroutine(WaitAndLaunch());
    }

    IEnumerator WaitAndLaunch()
    {
        yield return new WaitForSecondsRealtime(2);
        lmb.LoadsMenu();
    }
}
