using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // creates hook for the slider to function wwwww
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // health values for slider interaction
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
