using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsometricMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private float playerSpeed = 5; 
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
        var direction = (transform.position + playerInput) - transform.position; 
        var lookRotation = Quaternion.LookRotation(direction,Vector3.up);
        
        transform.rotation = lookRotation; 
    }

    void Move()
    {
        playerRb.MovePosition(transform.position + transform.forward * playerSpeed * Time.deltaTime); 
    }
}
