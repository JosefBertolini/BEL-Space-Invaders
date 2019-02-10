using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public UnityEvent WallBumpingEvent = new UnityEvent();
    public List<List<GameObject>> alienGrid = new List<List<GameObject>>();
}
