using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    PlayerControl playerScript;
    //Gatekey function
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }
    //The void function had to rely on the other code scripts otherwise it'll never work
    void OnMouseDown()
    {
        if(playerScript.hasKey == true)
        {
            Destroy(gameObject);
        }
    }


    //This code just removes the door IF the key is obtained
    void Update()
    {
        
    }
}
