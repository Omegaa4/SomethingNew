using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script was made by Alexander, following the August 2018 blackthornprod tutorial
public class SlotRefresh : MonoBehaviour
{   
    private Inventory inventory; //Inventory component variable named variable
    public int i; //An empty integer

// Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //Finds the component of the inventory type from a game object with a player tag and assigns it to the inventory variable
    }

// Update is called once per frame
    private void Update()
    {
        if (transform.childCount <= 0) //Checks how many children the game object the script is attached to has
        {
            inventory.isFull[i] = false; //Sets the index of i in the isFull array to false if there is no children
        }
    }

    //Method that is called when the slot's button is presssed
    public void DropItem()
    {
        foreach (Transform child in transform) //Foreach loop that runs for the number of children of the slot
        {
            child.GetComponent<Spawn>().SpawnDroppedItem(); //Calls method that simulates dropping the item
            GameObject.Destroy(child.gameObject); //Deletes the cloned object in the slots
        }
    }

}
