using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MoveCharacter
{
    public float downEnemy = 1f;

    float h = 1;
    bool left = true;

    ManagerEnemies manager;

    private void Awake()
    {
        manager = GetComponentInParent<ManagerEnemies>();
    }

    protected override void FixedUpdate()
    {
        h = left ? -1 : 1;
        Move(h);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            manager.Signal();
        }
    }
    
    public void ChangeDirection()
    {
        left = left ? false : true;
    }
}
