using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
public class BlockShooterAcces : MonoBehaviour
{
    [SerializeField] public UnityEvent onTriggerExitEvent;
    [SerializeField] public UnityEvent onTriggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }
}
