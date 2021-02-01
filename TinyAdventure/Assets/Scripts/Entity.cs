using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected string entityName;
    protected int maxHealth;
    protected int health;
    protected int attackDamage;
    protected float speed;
    protected bool isAlive = true;

    public string GetEntityName { get; private set;}
    public int GetMaxhealth { get; private set; }
    public int GetHealth { get; private set; }
    public int GetAttackDamage { get; private set; }
    public float GetSpeed { get; private set; }
    public bool GetAliveStatus { get; private set; }

    /// <summary>
    /// Set the stats of the Entity
    /// </summary>
    protected abstract void SetValues();

    public virtual void Attack(Entity entity)
    {
        entity.Hit(attackDamage);
    }

    public virtual void Hit(int damage)
    {
        if (health - damage <= 0)
        {
            health = 0;
            isAlive = false;
        }
        else
            health -= damage;
    }
}
