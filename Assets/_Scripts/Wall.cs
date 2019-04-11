using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Sprite spriteA;
    public Sprite spriteB;
    public int hp = 5;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void DamageWall(int loss)
    {
        if(hp == 4)
        {
            spriteRenderer.sprite = spriteA;
        }
        else if(hp == 2)
        {
            spriteRenderer.sprite = spriteB;
        }
        
        hp -= loss;
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
