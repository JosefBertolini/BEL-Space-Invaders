using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverOverlay;
    [SerializeField] private bool isDead;
    [SerializeField] private bool won;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayGameOver()
    {
        isDead = true;
        gameOverOverlay.SetActive(true);
    }

    public void DisplayWin()
    {
        won = true;
        gameOverOverlay.SetActive(true);
    }

    public void RestartGame()
    {
        isDead = false;
        won = false;
        Time.timeScale = 1;
    }

    public bool ReturnDead()
    {
        return isDead;
    }

    public bool ReturnWon()
    {
        return won;
    }
}
