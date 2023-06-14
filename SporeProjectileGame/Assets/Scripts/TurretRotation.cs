using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform mousePosition;
    public float rotationSpeed;

    private Quaternion lookRotation;
    private Vector3 direction; 
    // Update is called once per frame
    void Update()
    {

            direction = (mousePosition.position - transform.position).normalized;
            lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);


        //Vector3 lookAtRotation = Quaternion.LookRotation(mousePosition.position - transform.position).eulerAngles;
        //transform.rotation = Quaternion.Euler(Vector3.Scale(lookAtRotation, new Vector3 (0,1,0)));

    }
}
