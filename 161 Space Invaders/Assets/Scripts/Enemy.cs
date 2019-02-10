using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D m_rigidbody;

    private Collider2D m_collider;
    private Vector2 projectilePlacement;
    public GameObject enemyProjectile;

    public float speed;

    private void Awake()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        m_collider = this.GetComponent<Collider2D>();
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

    public void OnWallBumpEventListener()
    {
        speed = speed * -1;
        this.transform.position = new Vector3(this.transform.position.x,
                                              this.transform.position.y - 1, 0);
    }

    public void Shoot()
    {
        projectilePlacement = this.transform.position + new Vector3(0, -0.5f, 0);
        GameObject newBullet = Instantiate(enemyProjectile, projectilePlacement, Quaternion.identity);
        Physics2D.IgnoreCollision(m_collider, newBullet.GetComponent<Collider2D>());
    }
}
