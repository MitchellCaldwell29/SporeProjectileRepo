using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RayCastAim : MonoBehaviour
{
    private Camera cam;
    public LayerMask mask;

    public GameObject turretRayPosition; 
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DrawRay(); 
    }

    void DrawRay()//Draws the ray to thew mouse position which will use the turretRayPosition object to snap to the ray and then rotate the turret to this postion at a determined speed. 
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 500, mask))
        {
            turretRayPosition.transform.LookAt(new Vector3(hit.point.x, 1.35f, hit.point.z)); //turretRayPosition will look at the where the raycast hits 
            transform.rotation = Quaternion.Slerp(transform.rotation, turretRayPosition.transform.rotation, Time.deltaTime / rotationSpeed);
            //The turret will then rotate to the position of the turretRayPosition
        }
    }
}
