using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform mousePosition;

    // Update is called once per frame
    void Update()
    {
        //Vector3 relativePos = mousePosition.position - transform.position;
        Vector3 lookAtRotation = Quaternion.LookRotation(mousePosition.position - transform.position).eulerAngles;
        transform.rotation = Quaternion.Euler(Vector3.Scale(lookAtRotation, new Vector3 (0,1,0)));

    }
}
