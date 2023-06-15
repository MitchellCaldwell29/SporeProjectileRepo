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
    void Update()
    {
        DrawRay(); 
    }

    void DrawRay()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = cam.ScreenToWorldPoint(mousePos);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 500, mask))
        {
            turretRayPosition.transform.LookAt(new Vector3(hit.point.x, 1.35f, hit.point.z)); //Testing to see if camera will rotate. 
            transform.rotation = Quaternion.Slerp(transform.rotation, turretRayPosition.transform.rotation, Time.fixedDeltaTime * rotationSpeed);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 500, mask))
            {
                Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}