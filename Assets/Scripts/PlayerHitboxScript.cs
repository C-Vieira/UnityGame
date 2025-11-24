using UnityEngine;

public class PlayerHitboxScript : MonoBehaviour
{
    public AudioClip hurtSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // An enemy got through
        if (other.CompareTag("Enemy"))
        {
            // Play hurt sound (3x for louder)
            AudioSource.PlayClipAtPoint(hurtSound, transform.position);
            AudioSource.PlayClipAtPoint(hurtSound, transform.position);
            AudioSource.PlayClipAtPoint(hurtSound, transform.position);

            // Lose a life
            GameState.UpdateLives(-1);
        }
    }
}
