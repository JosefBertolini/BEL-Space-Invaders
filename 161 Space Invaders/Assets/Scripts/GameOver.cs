using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverOverlay;
    private GameManager gameManager;
    private EnemySpawner enemySpawner;
    private Player player;
    [SerializeField] private bool isDead;
    [SerializeField] private bool won;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
        player = GameObject.Find("Player").GetComponent<Player>();
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

    public void NextLevel()
    {
        gameManager.currentLevel++;
        player.lives++;
        enemySpawner.SpawnAliens();
    }
}
