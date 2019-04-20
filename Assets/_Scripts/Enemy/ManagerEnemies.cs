using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEnemies : MonoBehaviour
{
    public static ManagerEnemies instance;
    GameObject[] moveEnemy;
    //List<EnemyMove> enemyMove;
    
    private void Awake() {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start() 
    {
        //enemyMove = new List<EnemyMove>();

        if (moveEnemy == null)
        {
            moveEnemy = GameObject.FindGameObjectsWithTag("Enemy");
        }
    }

    // Señal de choque, Mandar mensaje a "Enemies"
    public void SignalChangeDirection()
    {
        foreach (GameObject enemy in moveEnemy)
        {
            enemy.GetComponent<EnemyMove>().ChangeDirection();
        }
    }

    public void SignalDownEnemy()
    {
        foreach (GameObject enemy in moveEnemy)
        {
            if(!enemy.gameObject.activeSelf)
            continue;
            enemy.GetComponent<EnemyMove>().DownEnemy();
        }
    }
        //
        // REDUCIR codigo: '¿Como se llama a un metodo?'
        //

    // public void Action( '?' )
    // {
    //     foreach (GameObject enemy in moveEnemy)
    //     {
    //         enemy.GetComponent<EnemyMove>(). '?' ;
    //     }
    // }
}
