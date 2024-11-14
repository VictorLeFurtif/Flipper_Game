using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBean : MonoBehaviour
{
    public GameObject VfxBean;
    public float delay = 10;
    public Compteur cpt;
    public int pointsvalue = 100;
    


    private void OnCollisionEnter(Collision other)
    {
        Vector3 positionParticule = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
        GameObject particuleInstance = Instantiate(VfxBean, positionParticule, Quaternion.identity);
        GetComponent<AudioSource>().Play();
        Destroy(particuleInstance, delay);
        cpt.UpdateScore(pointsvalue);

    }
}