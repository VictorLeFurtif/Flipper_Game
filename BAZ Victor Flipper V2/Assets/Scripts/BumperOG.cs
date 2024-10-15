using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperOG : MonoBehaviour
{
    public float strength = 1;
    public Animation anim;
    public AudioSource audio;
    public compteur cpt;
    public int pointsvalue = 100;
    private void OnCollisionEnter(Collision collision)
    
    {
        Vector3 force = (collision.transform.position - transform.position).normalized * strength;
        collision.rigidbody.AddForce(force);
        
        anim.Play("Maki Bump");
        audio.Play();
        cpt.UpdateScore(pointsvalue);
    }

 
}