using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 

public class SporePickUp : MonoBehaviour
{
    public GameObject GameManager;   

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "Spore")
        {
            GameManager.GetComponent<GameManagment>().UpdateSpore(+1);
            Destroy(gameObject);
        }
    }
}
