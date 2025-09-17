using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D rb;

    Vector2 direction;

    // Input
    void Update()
    {
        HandleInput();
    }

    // Movement
    void FixedUpdate()
    {
        MovePlayer();
    }

    /*
    *   Sets a Vec2 direction to move to by taking input from the Horizontal and Vertical axis
    */
    private void HandleInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }

    /*
    *   Updates the player's position by direction times speed
    */
    private void MovePlayer()
    {
        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
    }
}
