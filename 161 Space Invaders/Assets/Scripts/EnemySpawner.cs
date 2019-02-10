using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<List<Enemy>> enemyGrid = EnemyManager.AlienGrid;
    public GameObject enemyPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnAliens();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAliens()
    {
        for (int y = 0; y < 5; y++)
        {
            enemyGrid.Add(new List<Enemy>());
            for (int x = 0; x < 11; x++)
            {
                Vector3 spawnLocation = new Vector3((x-5), (y-2), 0);
                GameObject newEnemyObject = Instantiate(enemyPrefab, this.transform);
                newEnemyObject.transform.localPosition = spawnLocation;
                Enemy newEnemy = newEnemyObject.GetComponent<Enemy>();

                enemyGrid[y].Add(newEnemy);
            }
        }
    }
}
