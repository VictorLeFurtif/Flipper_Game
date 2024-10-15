using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperD : MonoBehaviour
{
    public float strength = 1;
    public Animation anim;
    public AudioSource audio;
    public compteur cpt;
    public int pointsvalue = 500;
    private void OnCollisionEnter(Collision collision)
    
    {
        Vector3 force = (collision.transform.position - transform.position).normalized * strength;
        collision.rigidbody.AddForce(force);
        
        anim.Play("Donut Animation");
        audio.Play();
        cpt.UpdateScore(pointsvalue);
    }

    
}
