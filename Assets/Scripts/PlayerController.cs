using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D rb;

    // Point position for instancing projectiles
    public Transform firePoint;
    // Projectile prefab to shoot
    public GameObject bullet;

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
        // Handle movement
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        // Handle shooting
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
        }
    }

    /*
    *   Updates the player's position by direction times speed
    */
    private void MovePlayer()
    {
        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
    }

    /*
    *  Instantiates a copy of the specified "bullet" prefab
    */
    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
