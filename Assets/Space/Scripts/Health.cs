using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{
    float maxHealth = 100f;
    float health;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        Vector3 pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    bool IsDead()
    {
        return health <= 0;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (IsDead())
            Destroy(gameObject);
    }

    public float GetHealth() { 
        return health;
    }

    public float GetMaxHealth()
    {
        return maxHealth;
    }

    public float GetPercent()
    {
        return health / maxHealth;
    }
}
