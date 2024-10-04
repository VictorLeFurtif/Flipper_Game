using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float strength = 1;
    public Animation anim;
    public AudioSource audio;
    private void OnCollisionEnter(Collision collision)
    
    {
        Vector3 force = (collision.transform.position - transform.position).normalized * strength;
        collision.rigidbody.AddForce(force);
        
        anim.Play("Bumper Bump");
        audio.Play();
        
    }
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
