using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//These public code are nessecary for the code to function
public class PlayerControl : MonoBehaviour
{
    public float speed;

    public float upRotation;
    public float downRotation;

    CharacterController characterControl;
    public Transform playerCam;
    public Camera mainCam;
    public float castDist;

    Vector3 vel;
    public float lookSensitivity;

    float xRotation = 0;

    public TMP_Text itemText;
    public string lookingAt = "Nothing";
    //For the text hud of the FirstPerson
    public bool hasKey = false;
    //This function will only go TRUE if the player finds the key

    //Simple coding if looking at something
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //This code just locks the cursor from the simulation
        characterControl = GetComponent<CharacterController>();
        itemText.text = lookingAt;
    }

    //Look sensitivity code
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
        playerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //This toggles the PlayerCam of its X rotation
        vel.z = Input.GetAxis("Vertical") * speed;
        vel.x = Input.GetAxis("Horizontal") * speed;
        //This imputs the float function to the vertical and horizontal axis
        vel = transform.TransformDirection(vel);
        characterControl.Move(vel * Time.deltaTime);
        //This mainly imputs the control of the player object with said void updates
    }

    //This runs in the same speed as the physics engine
    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 rayStart = mainCam.ViewportToWorldPoint(Input.mousePosition);
        if (Physics.Raycast(rayStart, playerCam.forward, out hit, castDist))
        {
            Debug.Log(hit.transform.name);
        }

    }

    //Raycast is an invisible line from the camera and the object





}
