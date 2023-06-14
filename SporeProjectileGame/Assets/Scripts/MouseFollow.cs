using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector3 pos;
    public float offset = 3f;
    private GameObject rayCastGroundTest; 


    void Update()
    {
        pos = Input.mousePosition;
        pos.z = offset;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }

        //pos = Input.mousePosition + rayCastGroundTest.transform.position;
        //pos.z = offset;
        //transform.position = Camera.main.ScreenToWorldPoint(pos);
        //Sets the raycast position to be where the object is instantiated on what surface. 

}
