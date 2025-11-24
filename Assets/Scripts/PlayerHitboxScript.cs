using UnityEngine;

public class PlayerHitboxScript : MonoBehaviour
{
    public AudioClip hurtSound;
    public AudioSource hurtAudio;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // An enemy got through
        if (other.CompareTag("Enemy"))
        {
            // Play hurt sound
            hurtAudio.PlayOneShot(hurtSound);

            // Lose a life
            GameState.UpdateLives(-1);
        }
    }
}
