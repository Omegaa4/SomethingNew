using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{ 
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    void Start() 
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }
    void OnCollisionEnter2D(Collision2D Collision) 
    {
        if (Collision.collider == true) 
        {
            TakeDamage(20);
        }
        void TakeDamage(int damage)
            {
                currentHealth -= damage;

                healthBar.SetHealth(currentHealth);
            }
    }
}