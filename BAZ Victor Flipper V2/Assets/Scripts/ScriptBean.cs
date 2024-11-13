using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBean : MonoBehaviour
{
    public GameObject VfxBean;
    
    
    private void OnCollisionEnter(Collision other)
    {
        Vector3 positionParticule = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
        Instantiate(VfxBean, positionParticule, Quaternion.identity);
    }
}
