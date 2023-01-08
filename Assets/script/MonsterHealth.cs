using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {  
            Destroy(gameObject);
        }

    }
  
}

