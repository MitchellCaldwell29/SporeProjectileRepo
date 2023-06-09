using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using System;
using UnityEngine.SceneManagement; 

public class GameManagment : MonoBehaviour
{
    public TextMeshProUGUI sporeText;
    public TextMeshProUGUI projectileText;
    public int sporeCount;
    public int projectileCount;


    // Start is called before the first frame update
    void Start()
    {
        sporeCount = 0;
        sporeText.text = "Spores: " + sporeCount;
        UpdateSpore(0);

        projectileCount = 0;
        projectileText.text = "Projectiles: " + projectileCount;
        UpdateProjectile(0);
    }

    private void Update()
    {

        if (sporeCount >= 3)
        {
            UpdateProjectile(1);
            UpdateSpore(-3);
        }
    }

    public void UpdateSpore(int addToSpore)
    {
        sporeCount += addToSpore;
        sporeText.text = "Spores: " + sporeCount;

    }

    public void UpdateProjectile(int addToProjectile)
    {
        projectileCount += addToProjectile;
        projectileText.text = "Projectiles: " + projectileCount;
    }

    public void Restart()//Loads a scene which will be how we restart the game.
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

