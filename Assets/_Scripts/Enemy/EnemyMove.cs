﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MoveCharacter
{
    public float downEnemy = 1f;

    float h = 1;
    bool left = true;

    protected override void FixedUpdate()
    {
        h = left ? -1 : 1;
        Move(h);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            ManagerEnemies.instance.SignalChangeDirection();
            Debug.Log("Chocamos con muro");
        }
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            ManagerEnemies.instance.SignalDownEnemy();
            Debug.Log("Bajamos");
        }
    }

    public void ChangeDirection()
    {
        left = left ? false : true;
    }
}
