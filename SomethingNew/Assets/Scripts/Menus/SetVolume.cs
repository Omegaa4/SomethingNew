using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    // variable calling audioMixer and putting it as MainMixer variable.
    public AudioMixer MainMixer;

    public void SetLevel (float sliderValue) //...
    {
       MainMixer.SetFloat("MasterVol", sliderValue);
    }
}
