using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class compteur : MonoBehaviour

{
    public int currentValueCounter = 0;
    private int donutPoint = 200;
    private int pizzaPoint = 100;
    private int salamiPoint = 500;
    private int makiPoint = 500;
    public TextMeshPro text_Pv;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        
    }
}
