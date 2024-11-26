using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Teleport : MonoBehaviour
{
    public GameObject objectWhereToTp;
    public Animation animCam;
    public GameObject ball;
    public TrailRenderer trail;
    public Transform ballPos;
    
    void TeleportTrail()
    {
        trail.SetPositions(new Vector3[]{ballPos.position});
        
    }

    void OnTriggerEnter(Collider other)
    {
        TeleportTrail();
        other.transform.position = new Vector3(objectWhereToTp.transform.position.x,
            objectWhereToTp.transform.position.y, objectWhereToTp.transform.position.z);
        other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        trail.enabled = false;
        
        animCam.Play("CameraSwitch");
        StartCoroutine(WaitForTimeScale(other));
    }

    IEnumerator WaitForTimeScale(Collider other)
    {
        yield return new WaitForSecondsRealtime(1);
        other.gameObject.GetComponent<MeshRenderer>().enabled = true;
        other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-2, 2), 0, 0), ForceMode.Impulse);
        TeleportTrail();
        trail.enabled = true;
    }
    
    /*public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            TeleportToCoffe();
        }
    }

    public void TeleportToCoffe()
    {
        TeleportTrail();
        ball.transform.position = new Vector3(objectWhereToTp.transform.position.x,
            objectWhereToTp.transform.position.y, objectWhereToTp.transform.position.z);
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.gameObject.GetComponent<MeshRenderer>().enabled = false;
        ball.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        TeleportTrail();
        animCam.Play("CameraSwitch");
        StartCoroutine(WaitForTimeScale2(ball));
    }
    
    IEnumerator WaitForTimeScale2(GameObject ball)
    {
        yield return new WaitForSecondsRealtime(1);
       ball.gameObject.GetComponent<MeshRenderer>().enabled = true;
       ball.gameObject.GetComponent<Rigidbody>().isKinematic = false;
       ball.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-2, 2), 0, 0), ForceMode.Impulse);
    }*/
    
}