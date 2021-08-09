using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{   
    private Inventory inventory;
    public int i;

// Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

// Update is called once per frame
    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        foreach (Transform child in transform) //Foreach loop that runs for the number of children of the slot
        {
            GameObject.Destroy(child.gameObject); //Deletes the cloned objects
        }
    }

}
