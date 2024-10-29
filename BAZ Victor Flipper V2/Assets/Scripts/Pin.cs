using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pin : MonoBehaviour
{
    public Animation anim;
    void Start()
    {
        gameObject.SetActive(false);
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.SetActive(true);
    }

    public void Update()
    {
        anim.Play();
    }
}