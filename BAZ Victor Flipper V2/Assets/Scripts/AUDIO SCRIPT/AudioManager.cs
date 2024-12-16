using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] generalAudio;
    public Slider volumeSlider;

    void Start()
    {
        generalAudio = FindObjectsOfType<AudioSource>();
        
        if (volumeSlider != null)
        {
            volumeSlider.onValueChanged.AddListener(UpdateVolume);
        }
    }

    public void UpdateVolume(float value)
    {
        foreach (var audioSource in generalAudio)
        {
            audioSource.volume = value;
        }
    }
}