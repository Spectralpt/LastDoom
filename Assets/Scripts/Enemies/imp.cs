using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class imp : MonoBehaviour
{
    private EnemyManger enemyManger;
    private Animator spriteAnimation;
    private angleToPlayer anglePlayer;

    [Header("Health Stats")]
    public float health;
    [Header("Attack Stats")]
    public float attackRange;
    public float impAttack;
    public float attackCooldown;
    private float attackCooldownLeft;
    
    public LayerMask playerLayer;
    
    //particulas
    public GameObject gunHitEffect;

    private void Start()
    {
        spriteAnimation = GetComponentInChildren<Animator>();
        anglePlayer = GetComponent<angleToPlayer>();
    }

    public void Update()
    {
        spriteAnimation.SetFloat("spriteRotation", anglePlayer.lastIndex);
        delayedAttack();
    }

    public void TakeDamage(float amount)
    {
        //particulas
        Instantiate(gunHitEffect, transform.position, Quaternion.identity, transform);

        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        // would be nice if we could ragdoll on death, because they are just a plane they would just flop which i think is hilarious
        Destroy(gameObject);
    }
    
    void Attack()
    {
        RaycastHit hit;
        //if (Physics.SphereCast(transform.position, 2, transform.forward, out hit , 5, playerLayer))
        if (Physics.Raycast(transform.position, transform.forward,out hit, attackRange))
        {
            HealthManager player = hit.transform.GetComponent<HealthManager>();
            player.ChangeHealth(-impAttack);
        }
    }

    void delayedAttack()
    {
        attackCooldownLeft -= Time.deltaTime;
        if (attackCooldownLeft <= 0f)
        {
            attackCooldownLeft = attackCooldown;
            Attack();
        }
    }
}

