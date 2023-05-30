using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    private void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical"); 

        Vector3 moveDirecton = new Vector3(xAxis, 0.0f, zAxis);

        transform.position += moveDirecton * speed;
    }
}
