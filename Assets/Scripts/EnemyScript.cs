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

        // Destroy the game object
        Destroy(gameObject);
    }
}
