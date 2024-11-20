using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SinkController : MonoBehaviour
{
    public float moveHorizontal = 0f;
    public float moveVertical = 0f;
    public Rigidbody rb;
    public float tiltSpeed = 10;
    public bool inSink = false;
    public float moveSpeed = 10f;
    

    void Update()
    {
        if (inSink == true)
        {
            StartCoroutine(ZFix());
            moveHorizontal = Input.GetAxis("Horizontal"); 
            moveVertical = Input.GetAxis("Vertical");
            Vector3 currentVelocity = rb.velocity;
            Vector3 direction = new Vector3(moveVertical*10, currentVelocity.y, -moveHorizontal*10);
            rb.velocity= direction*moveSpeed;
        }
        else
        {
            rb.constraints |= RigidbodyConstraints.FreezePositionZ;
        }
    }

    IEnumerator ZFix()
    {
        yield return new WaitForSeconds(4);
        rb.constraints &= ~RigidbodyConstraints.FreezePositionZ; 
    }

}
