using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;

    void OnTriggerEnter2D(Collider2D other) 
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if(damageDealer != null)
        {
            TakeDamage(damageDealer.GetDamage());
            damageDealer.Hit();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health + "%");

        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player dead");
        }
    }
}
