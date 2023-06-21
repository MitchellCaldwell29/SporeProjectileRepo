using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsometricMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRb; //Set a visible private field where later in Unity we can set the rigidbody of any object we put this script on. 
    [SerializeField] private float playerSpeed = 5; //The set value of the movement speed. 
    [SerializeField] private float turnSpeed = 360; //How fast should the turning rotation speed be. 360 sets it to 1 full 360 rotation a second.  
    private Vector3 playerInput; // Set a value for the Vector3 which is an ordered triplet of the x,y and z axis and represent them as a number (it represents a point, direction and/or length in 3D space. 
    [SerializeField] private Transform playerCanvasTransform; 

    void Update() //Updates once per frame
    {
        GatherInput();
        Look(); 
    }

    void FixedUpdate() //A fixed update is only called upon an input from the user. 
    {
        Move(); 
    }

    private void LateUpdate()//Happens after FixedUpdate
    {
        playerCanvasTransform.LookAt(Camera.main.transform);
    }

    void GatherInput() // Function that will gather the Input of the player. In this case W,A,S,D keys for moving up, down, left and right
    {
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")); //Player input (Vector3) = Input(W,A,S,D) from GetAxisRaw a feature which already is assigned to the W,A,S,D key
                                                                                                  //Horizontal tells us that it is reading the W,S keys, Y axis which is not used is set to 0, and the same with Vertical setting the input to the A,D keys. 
    }

    void Look()
    {
        if (playerInput != Vector3.zero)//If input does not equal, effectively making the player not snap back to the forward position
        {
            var matrix = Quaternion.Euler(0,45,0);// We will rotate these to these dimensions based on our Quaternion values.
                                                                    // In this case the camera is set to a 45 degree angle so we change the y axis to the same angle. Now up is in a North direction and not a diagonal direction.
                                                                    //Quaternion.Euler is used to rotate a vector position. 

            var alteredInput = matrix * playerInput;//Multiplies the matrix which we have set above by the vector which is our player Input. WILL NEED THIS FOR ENEMIES AND OTHER OBJECTS THAT MOVE!!!!!!

            var direction = (transform.position + alteredInput) - transform.position;//transform position of the player + player altered camera and movement position. The current transform position to find the relative angle between the old position and the new one. 
            var lookRotation = Quaternion.LookRotation(direction, Vector3.up);//Quaternion takes the 4D and turns them into a value for 3D axis (x,y and z) and the lookRotation will be the direction and
                                                                              //the Vector3 up (directional) so Unity will rotate around that axis

            transform.rotation = Quaternion.RotateTowards(transform.rotation,lookRotation,turnSpeed * Time.deltaTime);
        }

    }

    void Move()
    {
        playerRb.MovePosition(transform.position + (transform.forward * playerInput.magnitude) * playerSpeed * Time.deltaTime);
        //MovePosition moves the rigidbody towards the position we set. In this case the forward transform times the player input times magnitude(which returns the length of a vector) times player speed times
        // Time.deltaTime which is used to move a game object smoothly over several frames by calculating the distance the object travels and how many frames it takes to get to its destination. 
        //Magnitude will also read as 0 when there is no input and will not move the player continuously forward. 
    }
}
