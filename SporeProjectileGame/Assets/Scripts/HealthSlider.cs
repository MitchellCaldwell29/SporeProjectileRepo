using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthSlider : MonoBehaviour
{
    public Slider healthSlider;

    public void UpdateSlider(float value)
    {
        healthSlider.value = value;
        Debug.Log("Damage dealt");
    }
}
