using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2DController : MonoBehaviour
{
    public float Speed = 10f;
    public float lifetime = 2f;

    void Start()
    {
        // Shoot right
        GetComponent<Rigidbody2D>().linearVelocity = transform.right * Speed;

        // Destroy bullet after lifetime
        Destroy(gameObject, lifetime);  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy bullet
        Destroy(gameObject);

        // Destroy hazard if hit
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(collision.gameObject);
        }
    }
}


