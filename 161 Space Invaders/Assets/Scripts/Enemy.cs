﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D m_rigidbody;



    [System.NonSerialized] public float speed = 0.5f;

    private void Awake()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    private void Move()
    {
       // Vector2 currentVelocity = m_rigidbody.velocity;
        m_rigidbody.velocity = new Vector2(speed, 0f);
    }

    private void OnWallBumpEventListener()
    {
        m_rigidbody.velocity = (-1) * m_rigidbody.velocity;
        this.transform.position = new Vector3(this.transform.position.x,
                                              this.transform.position.y - 1, 0);
    }
}
