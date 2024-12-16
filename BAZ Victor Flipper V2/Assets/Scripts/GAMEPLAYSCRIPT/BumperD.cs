using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperD : MonoBehaviour
{
    public float strength = 1;
    public Animation anim;
    public Compteur cpt;
    public int pointsvalue = 500;
    [SerializeField] GameObject particlePrefab;
    public float donutStrenghts;
    
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 force = -collision.contacts[0].normal * strength;
        force += new Vector3(Random.Range(-donutStrenghts,donutStrenghts),0,0);
        collision.rigidbody.AddForce(force);
        GameObject particuleInstance = Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity, null);
        Destroy(particuleInstance, 1);
        
        anim.Play("Donut Animation");
        GetComponent<AudioSource>().Play();
        cpt.UpdateScore(pointsvalue);
    }

    
}
