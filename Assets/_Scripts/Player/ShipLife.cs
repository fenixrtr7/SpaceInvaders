using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLife : Life
{
    SpriteRenderer sprite;
    Color oneColor, twoColor;

    private void Start() {
        sprite = GetComponent<SpriteRenderer>();
        oneColor = new Color(255f, 110f, 110f, 255f);
        twoColor = new Color(255f, 0f, 0f, 255f);
    }
    public override void DamageWall(int loss)
    {
        base.DamageWall(loss);
        GameObject.Find("CanvasM").GetComponent<CanvasManager>().damaged = true;

        if(hp <= 0)
        { 
            GameObject.Find("CanvasM").GetComponent<CanvasManager>().PanelGameOver(true);
            Time.timeScale = 0;
        }else if (hp == 2)
        {
            sprite.color = oneColor;
        }else if (hp == 1)
        {
            sprite.color = twoColor;
        }
    }
}
