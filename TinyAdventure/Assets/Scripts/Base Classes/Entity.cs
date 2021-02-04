using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public string entityName { get; protected set;}
    public int maxHealth { get; protected set; }
    public int health { get; protected set; }
    public int attackDamage { get; protected set; }
    public float speed { get; protected set; }
    public bool isAlive { get; protected set; }

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
