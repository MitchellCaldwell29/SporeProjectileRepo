using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 3; // lifespan of the bullet in seconds

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisonEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
