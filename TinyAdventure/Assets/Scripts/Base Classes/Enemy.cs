using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Entity
{
    protected Player player;
    protected Rigidbody2D rb;

    protected void Awake()
    {
        player = GameManager.instance.player;
        rb = GetComponent<Rigidbody2D>();
        // add future variable here
    }

    protected Vector3 GetPlayerDirection()
    {
        Vector3 dir = (this.transform.position - player.transform.position).normalized;
        return dir;
    }

    protected void MoveToPlayer()
    {
        rb.velocity = GetPlayerDirection() * speed;
    }
}
