using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int lives = 3;
    [SerializeField] public bool canFire = true;
    [SerializeField] protected float speed = 5;
    private Rigidbody2D m_rigidbody;
    private Collider2D m_collider;
    public int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        m_collider = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    void Move()
    {
        float movementModifier = Input.GetAxisRaw("Horizontal");
        Vector2 currentVelocity = m_rigidbody.velocity;
        m_rigidbody.velocity = new Vector2(movementModifier * speed, currentVelocity.y);
    }

    void Shoot()
    {

    }
}
