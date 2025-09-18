using UnityEngine;

public class OffScreenDestructorAreaScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Don't destroy the player
        if (other.CompareTag("Player")) return;

        // Destroy anything else
        Destroy(other.gameObject);
    }
}
