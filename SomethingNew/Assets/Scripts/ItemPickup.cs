using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script was adapted from the 2018 blackthornprod inventory tutorial, and was written by Alexander
public class ItemPickup : MonoBehaviour
{
    private Inventory inventory; //Private variable called inventory that references the Inventory Class
    public GameObject itemButton; //Public game object variable called ligtningButton

    // Start is called before the first frame update
    private void Start()
    {
        //Sets the inventory variable as the Inventory component of the GameObject with the 'player' tag
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
    }

    void OnTriggerEnter2D(Collider2D hit) //Method with a parameter for a 2D Collider object
    {
        if (hit.CompareTag("Player")) //Check if hit has the 'player' tag
        {
            for (int i = 0; i < inventory.slots.Length; i++) //For loop that runs through the slots array, stopping when i is not less than the slots array length
            {
                if (inventory.isFull[i] == false) //Checks if the slot we are currently on is empty
                {
                    inventory.isFull[i] = true; //If the slot is empty then set it as full
                    Instantiate(itemButton, inventory.slots[i].transform, false); //Creates a clone of the object itemButton, puts it in the same position as the slot
                    Destroy(gameObject); //Destroys the item as the player has 'picked' it up
                    break; //Get out of the for loop
                }
            }         
        }
    }
}