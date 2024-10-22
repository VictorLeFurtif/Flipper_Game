using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class TutoScript : MonoBehaviour
{
    public GameObject tutoText;
    public GameObject textGoal;
   
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        tutoText.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        tutoText.SetActive(false);
        
        textGoal.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
        textGoal.SetActive(false);
    }
}
