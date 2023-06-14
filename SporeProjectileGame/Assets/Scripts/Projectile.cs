using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifespan = 3; // lifespan of the bullet in seconds
    public HealthScript healthScript;
    public int damage = 1; 

    private void Awake()
    {
        healthScript = FindObjectOfType<HealthScript>();
        Destroy(gameObject, lifespan);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            healthScript.TakeDamage(damage); 
            Destroy(gameObject);
        }

    }
}
