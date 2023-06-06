using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SporePickUp : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "Spore")
        Destroy(gameObject); 
    }

}
