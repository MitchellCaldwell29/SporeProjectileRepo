using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsometricMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private float playerSpeed = 5;
    [SerializeField] private float turnSpeed = 360; 
    private Vector3 playerInput;

    void Update()
    {
        GatherInput();
        Look(); 
    }

    void FixedUpdate()
    {
        Move(); 
    }

    void GatherInput()
    {
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")); 
    }

    void Look()
    {
        if (playerInput != Vector3.zero)
        {
            var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0)); 

            var alteredInput = matrix.MultiplyPoint3x4(playerInput);

            var direction = (transform.position + alteredInput) - transform.position;
            var lookRotation = Quaternion.LookRotation(direction, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation,lookRotation,turnSpeed * Time.deltaTime);
        }

    }

    void Move()
    {
        playerRb.MovePosition(transform.position + (transform.forward * playerInput.magnitude) * playerSpeed * Time.deltaTime); 
    }
}
