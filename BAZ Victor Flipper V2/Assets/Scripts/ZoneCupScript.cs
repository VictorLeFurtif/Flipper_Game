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
    public Rigidbody rbBall;
    public TrailRenderer trail;
    public Transform ballPos;
    
    void TeleportTrail()
    {
        trail.SetPositions(new Vector3[]{ballPos.position});
    }
    
    public void Start()
    {
        initialPosition = ball.transform.position;
    }

    

    public void OnTriggerEnter(Collider other)
    {   
        Debug.Log("Collision");
        if (!isGreen)
        {
            Debug.Log("Red");
            cpt.UpdateScore(-(cpt.currentValueCounter/2));
        }
        else
        {
            Debug.Log("Green");
            cpt.UpdateScore(cpt.currentValueCounter);
            
        }
        Debug.Log(initialPosition);
        trail.enabled = false;
        Teleport();
        StartCoroutine(WaitForTpAfter());
    }

    IEnumerator WaitForTpAfter()
    {
        yield return new WaitForSeconds(1);
        animCam.Play("CameraSwitchAfter");
        TeleportTrail();
        trail.enabled = true;
    }

    public void Teleport()
    {
        ball.transform.position = initialPosition;
        rbBall.velocity = Vector3.zero;
        rbBall.angularVelocity = Vector3.zero;
    }
    
    
}


