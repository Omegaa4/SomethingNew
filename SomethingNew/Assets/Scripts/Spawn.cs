using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script wass created by Alexander, modified from the blackthornprod 2018 inventory tutorial
public class Spawn : MonoBehaviour
{
    public GameObject item; //Variable of the GameObject type 
    private Transform playerTransform; //Transform component variable

   
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; //Sets the player variable to the transform property of the game object with the player tag
    }

    //Called when the cross linked with the slot is clicked, to simulate dropping the item
    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(playerTransform.position.x + 1, playerTransform.position.y); //Vector 2 that contains the player object's x position + 1 and the y position
        Instantiate(item, playerPos, Quaternion.identity); //Creates a new instance of the item in the slot, spawning in the position specified by the playerPos variable, with zero rotation
    }

   
}
