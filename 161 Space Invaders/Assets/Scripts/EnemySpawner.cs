using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<List<GameObject>> enemyGrid = new List<List<GameObject>>();
    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAliens()
    {
        for (int y = 0; y < 5; y++)
        {
            enemyGrid.Add(new List<GameObject>());
            for (int x = 0; x < 11; x++)
            {
                Vector3 spawnLocation = new Vector3(x, y, 0);
                GameObject newEnemyObject = Instantiate(enemyPrefab, this.transform);
                newEnemyObject.transform.localPosition = spawnLocation;

                enemyGrid[x].Add(newEnemyObject);
            }
        }
    }
}
