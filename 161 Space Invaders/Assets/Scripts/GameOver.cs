using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverOverlay;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            DisplayGameOver();
    }

    public void DisplayGameOver()
    {
        gameOverOverlay.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
    }
}
