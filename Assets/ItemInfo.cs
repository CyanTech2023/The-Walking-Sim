using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public string itemName;
    public int itemValue;

    PlayerControl playerScript;



    //This code indicates if the player is near a key
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }
    //void OnMouseOver()
    //{
    //    Debug.Log(itemName);
    //    playerScript.itemText.text = itemName;
    //}
    //We no longer need this void anymore
    //These void functions only detects whenever the mouse finds and hovers over
    void OnMouseDown()
    {
        //The public bool gets its signal right here ONLY if the key is obtained
        playerScript.hasKey = true;
        Destroy(gameObject);
    }
    //It also makes the object begone when clicked
    void Update()
    {
        
    }
}
