using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class shooter : MonoBehaviour
{
    public SpringJoint springJoint;
    public float defaultValue;
    public float minValue;
    public float currentValue;
    public float incrementSpeed = 1f;
    public KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        defaultValue = springJoint.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(key))
        {
            currentValue = currentValue - incrementSpeed; 
            if (currentValue < minValue)
            {
                currentValue = minValue;
            }
            
            
        }
        else
        {
            currentValue = defaultValue;
        }
        
        springJoint.spring = currentValue;

    }
}
