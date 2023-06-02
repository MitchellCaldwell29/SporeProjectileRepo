using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform mousePosition;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = mousePosition.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos, new Vector3 (0,1,0));  
    }
}
