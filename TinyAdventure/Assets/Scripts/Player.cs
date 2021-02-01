using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    protected override void SetValues()
    {
        entityName = "player";
        maxHealth = 100;
        health = maxHealth;
        attackDamage = 1;
        speed = 10;
    }
}
