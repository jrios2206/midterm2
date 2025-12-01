using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f; 

    private Rigidbody2D rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.left * speed;
        }
    }

    void Update()
    {
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
