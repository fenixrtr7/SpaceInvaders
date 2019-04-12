using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipLife : Life
{
    public override void DamageWall(int loss)
    {
        base.DamageWall(loss);
        GameObject.Find("CanvasM").GetComponent<CanvasManager>().damaged = true;

        if(hp <= 0)
        { 
            GameObject.Find("CanvasM").GetComponent<CanvasManager>().PanelGameOver(true);
            Time.timeScale = 0;
        }
    }
}
