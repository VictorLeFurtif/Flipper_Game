using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScreenShacker : MonoBehaviour
{
  [SerializeField] float          displacementIntensity = 1;
  [SerializeField] float          rotationIntensity     = 1;
  [SerializeField] AnimationCurve intensityCurve;
  public        List<ScreenShake> screenShakes = new();

  public static ScreenShacker      instance;

  void Awake()
  {
     instance = this; //L'objet qui porte le script est devient instance
  }

  public void Shake(float stress, float duration)
  {
     screenShakes.Add(new ScreenShake
     {
        stress   = stress,
        duration = duration
     });
  }

  void Update()
  {
     if (screenShakes.Count > 0)
     {
        UpdateShakesDuration();
        ShakeBiggest();
     }
  }

  void UpdateShakesDuration()
  {
     for (int i = screenShakes.Count - 1; i >= 0; i--)
     {
        screenShakes[i].currentDuration += Time.deltaTime;

        if (screenShakes[i].currentDuration >= screenShakes[i].duration)
        {
           screenShakes.RemoveAt(i);

           if (i == 0)
           {
              transform.localPosition = Vector3.zero;
              transform.localRotation = Quaternion.identity;
           }
        }
     }
  }
int   index;
  float biggestShake;
  float intensityToCompare;

  void ShakeBiggest()
  {
     index        = -1;
     biggestShake = 0;

     for (int i = 0; i < screenShakes.Count; i++)
     {
        intensityToCompare = screenShakes[i].stress * intensityCurve.Evaluate(screenShakes[i].currentDuration / screenShakes[i].duration);

        if (biggestShake < intensityToCompare)
        {
           biggestShake = intensityToCompare;
           index        = i;
        }
     }

     if (index != -1)
     {
        ShakeIt(screenShakes[index]);
     }
  }

  float intensityCurveEvaluated;

  void ShakeIt(ScreenShake screenShake)
  {
     Debug.Log("ShakeIt");

     intensityCurveEvaluated = intensityCurve.Evaluate(screenShake.currentDuration / screenShake.duration);

     transform.localPosition = (transform.right * (Random.Range(-1, 1) * intensityCurveEvaluated)
                                + transform.up  * (Random.Range(-1, 1) * intensityCurveEvaluated)) * (displacementIntensity * screenShake.stress);

     transform.localRotation = Quaternion.Euler(
        Random.Range(-rotationIntensity, rotationIntensity) * intensityCurveEvaluated * screenShake.stress,
        Random.Range(-rotationIntensity, rotationIntensity) * intensityCurveEvaluated * screenShake.stress,
        Random.Range(-rotationIntensity, rotationIntensity) * intensityCurveEvaluated * screenShake.stress);
  }
}

[Serializable] public class ScreenShake
{
  public float stress;
  public float duration;
  public float currentDuration;
}
