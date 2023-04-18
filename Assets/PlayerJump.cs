using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This code is CodingDino's, the code may be changed but credit goes to the original coder. Here's the link:
//https://gist.github.com/CodingDino/0eeb188bf3515b1d252872ebb535d606

//NOTE: Jump code haven't finished!
public class PlayerJump : MonoBehaviour
{
    
    public float jumpForce = 15f;
    
    public string groundTag = "Ground";
    
    private bool touchingGround = false;

    private bool attemptJump = false;
    //the first four determines the force of said jump and signals if the player is on the ground
    public void Jump()
    {
        attemptJump = true;

    }
    //This public void determines the access for the jump function
    
    public void FixedUpdate()
    {
        if (attemptJump)
        {
            if (touchingGround == true)
            {
                //for 3d edit in Unity, the rigidbody is needed (excluding 2d)
                Rigidbody ourRigidbody = GetComponent<Rigidbody>();
                ourRigidbody.AddForce(Vector2.up * jumpForce);
            }
            attemptJump = false;
        }
        touchingGround = false;
    }
    //This other public void sets the jumping fuction with the force of the jump, temperally closing the attemptJump when the player's from the ground
    public void OnCollisionStay(Collision collision)
    {
        
        if (collision.collider.CompareTag(groundTag) == true)
        {
            touchingGround = true;
            //For if the player is back on the ground, the function is ready to be used again
        }
    }
}