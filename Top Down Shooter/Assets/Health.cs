using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth, damage, currentHealth;

    void start()
    {
        if(gameObject.tag == "Player")
        {
            currentHealth = maxHealth = 100f;
            damage = 25f;
        }

        else if(gameObject.tag == "Enemy")
        {
            currentHealth = maxHealth = 50f;
            damage = 25f;
        }
    }

    
}
