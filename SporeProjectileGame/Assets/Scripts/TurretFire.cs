using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectile.GetComponent<Rigidbody>().velocity = projectileSpawnPoint.forward * projectileSpeed;
        }

    }
}

