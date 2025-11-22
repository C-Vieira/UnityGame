using UnityEditor;
using UnityEngine;

public class EnemyMediumScript : MonoBehaviour
{
    public float speed = 2.0f;
    public Rigidbody2D rb;
    public GameObject dashTriggerCollider;

    void FixedUpdate()
    {
        // Move down towards the bottom of the screen
        rb.MovePosition(rb.position + new Vector2(0.0f, -1.0f) * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Player entered the dash trigger
        if (other.CompareTag("Player"))
        {
            // Increase speed
            speed = 10.0f;
        }
    }
}
