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

    // Señal de choque, Mandar mensaje a "Enemies"
    public void Signal()
    {
        foreach (GameObject enemy in moveEnemy)
        {
            enemy.GetComponent<EnemyMove>().ChangeDirection();
            enemy.GetComponent<EnemyMove>().DownEnemy();
        }
    }
}
