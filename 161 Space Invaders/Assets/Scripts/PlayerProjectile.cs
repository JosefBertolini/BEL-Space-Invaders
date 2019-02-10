using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{

    [SerializeField] protected float speed = 9.0f;
    private Rigidbody2D bulletBody;

    // Start is called before the first frame update
    void Start()
    {
        bulletBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletBody.velocity = new Vector2(bulletBody.velocity.x, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // CHECK FOR ENEMY PROJ
        // INVOKE EVENT FOR CAN_SHOOT
        Destroy(this.gameObject);
    }
}
