using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Health property
    public float Health
    {
        set
        {
            health = value;
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
    public float score = 5.0f;

    private void DestroyEnemy()
    {
        // Give Score
        GameState.UpdateScore(score);

        // Destroy the game object
        Destroy(gameObject);
    }
}
