using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Life
{
    public Sprite spriteA;
    public Sprite spriteB;
    SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public override void DamageWall(int loss)
    {
        if(hp == 4)
        {
            spriteRenderer.sprite = spriteA;
        }
        else if(hp == 2)
        {
            spriteRenderer.sprite = spriteB;
        }
        base.DamageWall(loss);
    }
}
