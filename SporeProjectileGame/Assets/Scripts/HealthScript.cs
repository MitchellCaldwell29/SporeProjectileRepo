using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthScript : MonoBehaviour
{
    public Image healthBar; 

    public int health;
    public int maxHealth;


    void Start()
    {
        health = maxHealth;
        UpdateHealthBar();
    }
    
    public void TakeDamage(int amount)
    {
        health -= amount; 
        UpdateHealthBar();

        if(health <= 0)
        {
            Destroy(gameObject); //Destroy player 
        }
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
