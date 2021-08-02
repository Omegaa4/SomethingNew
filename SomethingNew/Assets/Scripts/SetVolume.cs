using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer MainMixer;

    public void SetLevel (float sliderValue)
    {
       MainMixer.SetFloat("MasterVol", sliderValue);
    }
}
