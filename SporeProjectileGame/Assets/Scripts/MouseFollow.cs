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

        //pos = Input.mousePosition + rayCastGroundTest.transform.position;
        //pos.z = offset;
        //transform.position = Camera.main.ScreenToWorldPoint(pos);
        //This sets the raycast to show wherever the cube is instantiated. 
    }
}
