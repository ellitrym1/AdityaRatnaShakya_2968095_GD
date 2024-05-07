using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth5 : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetTrigger("Death");
    }
}
