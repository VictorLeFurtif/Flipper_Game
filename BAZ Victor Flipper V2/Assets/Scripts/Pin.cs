using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Pin : MonoBehaviour
{
    public Animation anim;
    public AudioSource audioButton;
    
    void Start()
    {
        gameObject.SetActive(false);
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.SetActive(true);
        audioButton.Play();
    }

    public void Update()
    {
        anim.Play();
    }
}