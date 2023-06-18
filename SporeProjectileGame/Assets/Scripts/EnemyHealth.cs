using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
       
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
