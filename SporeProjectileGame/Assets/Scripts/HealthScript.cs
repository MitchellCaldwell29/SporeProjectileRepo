using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public float health;
    public float maxHealth;
    public GameObject healthBar;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.GetComponent<HealthSlider>().UpdateSlider(health / maxHealth);
    }
}
