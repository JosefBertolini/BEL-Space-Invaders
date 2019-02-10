using System.Collections;
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
    private float timeElapsed = 0;
    private List<int> checkedColumns = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDead()
    {
        Time.timeScale = 0;
        gameOverOverlay.SetActive(true);
    }
}
