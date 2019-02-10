﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public int score = 0;
    public GameObject gameOverOverlay;
    public UnityEvent WallBumpingEvent = new UnityEvent();
    public List<List<GameObject>> alienGrid = new List<List<GameObject>>();

    [SerializeField] protected float maxTimeToShoot;
    private float timeElapsed;
    private float randomTime;

    // Start is called before the first frame update
    void Start()
    {
        timeElapsed = 0.0f;
        randomTime = Random.Range(0.0f, maxTimeToShoot);
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > randomTime)
        {
            FindShooter();
            randomTime = Random.Range(0.0f, maxTimeToShoot);
            timeElapsed = 0.0f;
        }
    }

    public void PlayerDead()
    {
        Time.timeScale = 0;
        gameOverOverlay.SetActive(true);
    }

    void FindShooter()
    {
        int[] temp = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> columnsToCheck = new List<int>(temp);

        for (int x = 0; x < 11; x++)
        {
            int index = Random.Range(0, 11-x);

            for (int y = 0; y < 5; y++)
            {
                if (alienGrid[index][y].CompareTag("Enemy"))
                {
                    Enemy foundEnemy = alienGrid[index][y].GetComponent<Enemy>();
                    foundEnemy.Shoot();
                    return;
                }
            }

            columnsToCheck.RemoveAt(index);
        }
    }
}
