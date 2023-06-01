using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    private Camera _cam;
    [SerializeField, Range(1, 100)] private float _rotationSpeed; 
    // Start is called before the first frame update
   
    void Awake()
    {
        _cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        mousePosition.x = 0;

        transform.up = Vector3.MoveTowards(transform.up, mousePosition, _rotationSpeed * Time.deltaTime);
    }
}
