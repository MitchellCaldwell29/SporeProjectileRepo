using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public GameObject gameManager;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10;
    public bool shootProjectile;

    private void Update()
    {
        if (gameManager.GetComponent<GameManagment>().projectileCount <= 0)
        {
            shootProjectile = false;
        }
        if (gameManager.GetComponent<GameManagment>().projectileCount > 0)
        {
            shootProjectile = true;
            
            if (shootProjectile == true)
            {
                ProjectileShoot();
            }
        }
    }

    public void ProjectileShoot()
    {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);//create the projectile
                projectile.GetComponent<Rigidbody>().velocity = projectileSpawnPoint.forward * projectileSpeed;//fire the projectile forward 
                
                gameManager.GetComponent<GameManagment>().projectileCount--;
                gameManager.GetComponent<GameManagment>().projectileText.text = "Projectiles: " + gameManager.GetComponent<GameManagment>().projectileCount; 
            }
    }
}

    


