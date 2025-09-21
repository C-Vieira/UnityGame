using UnityEngine;

public class PlayerHitboxScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // An enemy got through
        if (other.CompareTag("Enemy"))
        {
            // Lose a life
            GameState.UpdateLives(-1);
        }
    }
}
