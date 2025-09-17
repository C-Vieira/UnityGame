using UnityEngine;

public class EnemyBasicScript : MonoBehaviour
{
    public float speed = 2.0f;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        // Move down towards the bottom of the screen
        rb.MovePosition(rb.position + new Vector2(0.0f, -1.0f) * speed * Time.deltaTime);
        
    }
}
