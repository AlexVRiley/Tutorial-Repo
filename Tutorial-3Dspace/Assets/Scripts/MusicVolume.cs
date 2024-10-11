using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
    public AudioMixer Mixer;

    public void set_level(float sliderValue) 
    {
        Mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
