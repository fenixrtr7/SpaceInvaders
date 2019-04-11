using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed = 6;

    Rigidbody2D rigid;

    private void Start() {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        rigid.AddForce(Vector2.up * speed * Time.deltaTime, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
