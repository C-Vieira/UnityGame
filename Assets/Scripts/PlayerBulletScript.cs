using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Destroy the hit enemy
            Destroy(other.gameObject);
            // TODO: Award some points per enemy defeated

            // Also destroy the bullet object
            Destroy(gameObject);
        }
    }

}
