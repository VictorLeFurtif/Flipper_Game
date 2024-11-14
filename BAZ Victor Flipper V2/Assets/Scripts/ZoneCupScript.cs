using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCupScript : MonoBehaviour
{
    public bool isGreen;
    public Compteur cpt;
    public Vector3 initialPosition = new Vector3();
    public GameObject ball;
    public Animation animCam;


    public void Start()
    {
        initialPosition = ball.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!isGreen)
        {
            cpt.UpdateScore(-(cpt.currentValueCounter/2));
            StartCoroutine(WaitForTpAfter());
        }
        else
        {
            cpt.UpdateScore(cpt.currentValueCounter);
            StartCoroutine(WaitForTpAfter());
        }
    }

    IEnumerator WaitForTpAfter()
    {
        yield return new WaitForSeconds(1);
        ball.transform.position = initialPosition;
        animCam.Play("CameraSwitchAfter");
    }
}
