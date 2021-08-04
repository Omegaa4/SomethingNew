using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
  //values for base hp, call for currenthealth
  public int maxHealth = 100;
  public int currentHealth;

  public HealthBar healthBar;

 void Start() {
      currentHealth = maxHealth;
      healthBar.SetMaxHealth(maxHealth);
  }

 void Update() {
      if (Input.GetKeyDown(KeyCode.Space))
      {
          TakeDamage(20);
      }
  }
 void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    /* painful insert brung to you by late night coder, Linyx...
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetMaxHealth(currentHealth);
    }
    im an idiot, i spend a whole 20 minutes 
    trying to figure out why the slider wasn't moving.
    I WAS CHANGING THE MAX HP NOT CURRENT!!! */
}
