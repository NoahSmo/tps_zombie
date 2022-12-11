using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Data", menuName = "Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public int health;
    public int damage;
    public float speed;
    public float attackRange;
    public float attackRate;
    public float attackCooldown;
    
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    
    public void Attack()
    {
        attackCooldown = attackRate;
    }
    
    public void Update()
    {
        if (attackCooldown > 0)
        {
            attackCooldown -= Time.deltaTime;
        }
    }
    
    public bool CanAttack()
    {
        return attackCooldown <= 0;
    }
}
