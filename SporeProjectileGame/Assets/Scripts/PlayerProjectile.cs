using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float lifespan = 3; // lifespan of the bullet in seconds
    public EnemyHealth enemyHealth;
    public int damage = 1;

    private void Awake()
    {
        enemyHealth = FindObjectOfType<EnemyHealth>();
        Destroy(gameObject, lifespan);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            enemyHealth.TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}