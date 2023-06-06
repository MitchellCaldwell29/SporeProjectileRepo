using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RayCastAim : MonoBehaviour
{
    Camera cam; 
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        // Draw Ray
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue); 
    }
}
