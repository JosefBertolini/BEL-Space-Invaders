using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverOverlay;
    [SerializeField] private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
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

    public void RestartGame()
    {
        isDead = false;
        Time.timeScale = 1;
    }

    public bool returnDead()
    {
        return isDead;
    }
}
