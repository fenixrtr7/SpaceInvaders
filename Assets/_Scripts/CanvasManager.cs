using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    //public List<Image> lifeImage = new List<Image>();
    public float turnDelay = 0.2f;
    public float flashSpeed = 5f;

    Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    Image redPanel;
    public GameObject gameOverPanel;
    public bool damaged;

    private void Awake() {
        redPanel = GameObject.Find("PanelRed").GetComponent<Image>();
        // gameOverPanel = GameObject.Find("PanelBlack").GetComponent<GameObject>();
    }

    private void Update() {
        if(damaged)
        {
            redPanel.color = flashColor;
        }
        else
        {
            redPanel.color = Color.Lerp (redPanel.color, Color.clear, flashSpeed * Time.deltaTime);
        } // Lerp => Interpolar el color
        damaged = false;
    }

    // Activamos Panel GameOver
    public void PanelGameOver(bool onGameOver)
    {
        //bool prueba;
        // if(onGameOver)
        // {
            gameOverPanel.SetActive(onGameOver);
        // }else
        // {
        //     gameOverPanel.SetActive(false);
        // }
        
    }
}
