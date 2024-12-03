using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderQTE : MonoBehaviour
{
    public bool CanTurn = false;
    public Slider sliderRound;
    
    
    void Update()
    {
        
        if (CanTurn == true)
        {

            StartCoroutine(SliderTime());

        }
    }

    IEnumerator SliderTime()
    {
        yield return new WaitForSeconds(3);
        sliderRound.value = Mathf.Lerp(sliderRound.value, 1,0.005f );
    }
    
    
}

