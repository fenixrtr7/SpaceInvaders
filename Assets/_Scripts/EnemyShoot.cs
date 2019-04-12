using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    float delay;
    public GameObject shot;
    public LayerMask blockingLayer;

    protected float contador = 0;
    bool noEnemy = false;
    private void Start()
    {
        delay = Random.Range(1, 5);
    }
    protected virtual void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down / 3, Color.blue);
        contador += Time.deltaTime;

        if (contador >= delay)
        {
            if (CanShoot() == true)
            {
                Instantiate(shot, transform.position, Quaternion.identity);
                contador = 0;
                delay = Random.Range(1, 5);
            }
            else
            {
                contador = 0;
                delay = Random.Range(1, 5);
            }
        }
    }

    bool CanShoot()
    {
        RaycastHit2D hit;
        Vector2 start = transform.position;
        hit = Physics2D.Linecast(start, Vector2.down / 2, blockingLayer);

        return (hit.collider == null) ? true : false;

    }
}
