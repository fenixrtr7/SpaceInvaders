using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemies : MonoBehaviour
{
    GameObject[] moveEnemy;

    private void Start() 
    {
        if (moveEnemy == null)
        {
            moveEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        }
    }

    public void Signal()
    {
        Debug.Log("Choco enemigo");
        foreach (GameObject enemy in moveEnemy)
        {
            enemy.GetComponent<EnemyMove>().ChangeDirection();
        }
    }
}
