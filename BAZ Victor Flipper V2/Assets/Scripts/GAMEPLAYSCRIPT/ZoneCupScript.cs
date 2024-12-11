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
    public GameObject goodVFX;
    public GameObject badVFX;
    public Vector3 positionCup = new Vector3();
    public float delay = 10;
    
    void TeleportTrail()
    {
        trail.SetPositions(new Vector3[]{ballPos.position});
    }
    
    public void Start()
    {
        initialPosition = ball.transform.position;
        positionCup = transform.position;
    }

    

    public void OnTriggerEnter(Collider other)
    {   
        Debug.Log("Collision");
        if (!isGreen)
        {
            GameObject particuleInstance = Instantiate(badVFX, positionCup, Quaternion.identity);
            Debug.Log("Red");
            cpt.UpdateScore(-(cpt.currentValueCounter/2));
            Destroy(particuleInstance, delay);
        }
        else
        {
            GameObject particuleInstanceBis = Instantiate(goodVFX, positionCup, Quaternion.identity);
            Destroy(particuleInstanceBis, delay);
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


