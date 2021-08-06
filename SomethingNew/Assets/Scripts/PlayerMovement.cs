using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // public variables, speed and ref rb for varible.
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    
    // vector2 allows for vector point movement.
    Vector2 movement;
    void Update()
    {
        // grab horzontal and vertical inputs (wasd,arrows)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // move rigidbody from position and movement times speed times time for framerate.
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
