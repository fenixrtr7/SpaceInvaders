using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    public float delay = 0.5f;
    public GameObject shot;

    float contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        contador += Time.deltaTime;

        if (Input.GetAxisRaw("Fire1") == 1 && contador >= delay)
        {
            Instantiate(shot, transform.position,Quaternion.identity);
            contador = 0;
        }
    }
}
