using System.Collections;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Health property
    public float Health
    {
        set
        {
            if (!isInvincible)
            {
                // Play hurt sound (3x for louder)
                AudioSource.PlayClipAtPoint(hurtSound, transform.position);
                AudioSource.PlayClipAtPoint(hurtSound, transform.position);
                AudioSource.PlayClipAtPoint(hurtSound, transform.position);

                health = value;
            }
            
            if (health <= 0)
            {
                DestroyEnemy();
            }
        }
        get
        {
            return health;
        }
    }
    // Make accessible through the editor, but keep private
    [SerializeField]
    private float health = 1.0f;
    // Make enemies not take damage when offscreen
    private bool isInvincible = true;

    // Sounds
    public AudioClip hurtSound;
    public AudioClip deathSound;

    public float score = 5.0f;

    // Make enemies able to take damage only after they appear on screen
    private IEnumerator OnBecameVisible()
    {
        // Small delay
        yield return new WaitForSeconds(0.5f);
        isInvincible = false;       
    }

    private void DestroyEnemy()
    {
        // Give Score
        GameState.UpdateScore(score);

        // Increase enemy count
        GameState.IncreaseEnemyCount();

        // Play death sound (3x for louder)
        AudioSource.PlayClipAtPoint(deathSound, transform.position);
        AudioSource.PlayClipAtPoint(deathSound, transform.position);
        AudioSource.PlayClipAtPoint(deathSound, transform.position);

        // Destroy the game object
        Destroy(gameObject);
    }
}
