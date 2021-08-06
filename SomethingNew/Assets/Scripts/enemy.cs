using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{   
    //public var and ints all related to managing dmg

    public int maxHealth = 100; 
    public int currentHealth;
    public HealthBar healthBar;
    void Start() 
        {
            //set current health to maxHealth and display on bar.
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }
    void OnCollisionEnter2D(Collision2D Collision) //detect collisions
    {
        if (Collision.collider == true) //if there is collision take 20 dmg
        {
            TakeDamage(20);
        }
        void TakeDamage(int damage) //send damage and update healthBar
            {
                currentHealth -= damage;

                healthBar.SetHealth(currentHealth);
            }
    }
}