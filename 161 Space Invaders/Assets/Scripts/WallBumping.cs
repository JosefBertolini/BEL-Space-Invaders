using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WallBumping : MonoBehaviour
{
    private bool wasBumped = false;

    public UnityEvent OnWallBumpEvent = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!wasBumped)
        {
            OnWallBumpEvent.Invoke();
            wasBumped = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        wasBumped = false;
    }
}
