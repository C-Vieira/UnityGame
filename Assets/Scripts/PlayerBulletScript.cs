using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    public float speed = 20.0f;
    public float damage = 1.0f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.linearVelocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyScript enemyScript = other.GetComponent<EnemyScript>();
        if (enemyScript != null)
        {
            // Deal damage to enemy
            enemyScript.Health -= damage;

            // Destroy the bullet object
            Destroy(gameObject);
        }
    }

}
