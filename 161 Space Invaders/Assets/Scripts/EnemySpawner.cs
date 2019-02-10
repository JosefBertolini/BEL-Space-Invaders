using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    GameObject parent_object;
    LevelManager levelManagerComponent;

    private void Awake()
    {
        parent_object = this.transform.parent.gameObject;
        levelManagerComponent = parent_object.GetComponent<LevelManager>();
    }
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
            for (int x = 0; x < 11; x++)
            {
                Vector3 spawnLocation = new Vector3((x-5), (y-2), 0);
                GameObject newEnemyObject = Instantiate(enemyPrefab, this.transform);
                newEnemyObject.transform.localPosition = spawnLocation;
                Enemy newEnemyComponent = newEnemyObject.GetComponent<Enemy>();
                levelManagerComponent.WallBumpingEvent.AddListener(newEnemyComponent.OnWallBumpEventListener);
            }
        }
    }
}
