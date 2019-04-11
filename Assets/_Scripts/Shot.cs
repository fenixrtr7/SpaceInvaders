using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed = 6;
    public int damage = 1;

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
        else if(other.gameObject.CompareTag("Block"))
        {
            other.gameObject.GetComponent<Wall>().DamageWall(damage);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<ShipLife>().DamageWall(damage);
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("Shoot"))
        {
            Destroy(this.gameObject);
        }
    }
}
