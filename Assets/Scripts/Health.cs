using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] ParticleSystem hitEffect;

    void OnTriggerEnter2D(Collider2D other) 
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if(damageDealer != null)
        {
            TakeDamage(damageDealer.GetDamage());
            PlayHitEffect();
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

    void PlayHitEffect()
    {
        if(hitEffect != null)
        {
            ParticleSystem istance = Instantiate(hitEffect, transform.position , Quaternion.identity);
            Destroy(istance.gameObject, istance.main.duration + istance.main.startLifetime.constantMax);
        }
    }
}
