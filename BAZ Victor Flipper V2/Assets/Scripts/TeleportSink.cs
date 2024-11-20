using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSink : MonoBehaviour
{
    public GameObject objectWhereToTp;
    public Animation animCam;
    public SliderQTE sQte;
   


    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        other.transform.position = new Vector3(objectWhereToTp.transform.position.x,
            objectWhereToTp.transform.position.y, objectWhereToTp.transform.position.z);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        rb.isKinematic = true;
        sQte.CanTurn = true;
        animCam.Play("CameraSink");
       
        StartCoroutine(WaitForTimeScale(other));
    }

    IEnumerator WaitForTimeScale(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        yield return new WaitForSecondsRealtime(2);
        other.gameObject.GetComponent<MeshRenderer>().enabled = true;
        rb.isKinematic = false;
    }
}
