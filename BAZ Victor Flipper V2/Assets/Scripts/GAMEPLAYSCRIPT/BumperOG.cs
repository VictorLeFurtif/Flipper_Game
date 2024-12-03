using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperOG : MonoBehaviour
{
    public float strength = 1;
    public Animation anim;
    public AudioSource audioOG;
    public Compteur cpt;
    public int pointsvalue = 100;
    [SerializeField] GameObject particlePrefab;
    
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 force = -collision.contacts[0].normal * strength;
        collision.rigidbody.AddForce(force);
        GameObject particuleInstance = Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity, null);
        Destroy(particuleInstance, 1);
        anim.Play("Maki Bump");
        audioOG.Play();
        cpt.UpdateScore(pointsvalue);
    }


}