﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float speed = 6f;
    public int factorDown = 15;

    Vector3 movement;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    protected virtual void Start()
    {
            rigid = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate() 
    {
        float h = Input.GetAxisRaw("Horizontal");
        Move(h);   
    }

    // Movimiento
    protected virtual void Move(float h)
    {
        movement.Set(h, 0f, 0f);
        rigid.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }

    //Enemigo baja
    public void DownEnemy()
    {
        transform.Translate(Vector3.down / factorDown);
    }
}
