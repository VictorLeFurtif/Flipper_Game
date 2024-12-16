using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float strength = 1;
    public Animation anim;
    public Compteur cpt;
    public int pointsvalue = 200;
    [SerializeField] GameObject particlePrefab;
    public bool isSushi = false;
    public float strengthSushi = 1;
    
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 force = -collision.contacts[0].normal * strength;
        
        if (isSushi)
        {
            force += new Vector3(strengthSushi,0,0);
        }
        collision.rigidbody.AddForce(force);
        GameObject particuleInstance = Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity, null);
        Destroy(particuleInstance, 1);
        anim.Play();
        GetComponent<AudioSource>().Play();
        cpt.UpdateScore(pointsvalue);
    }
    
    
}

