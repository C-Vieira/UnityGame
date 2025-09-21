using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public Text livesText;
    public Text scoreText;
    private static int lives = 4;
    private static float score = 0.0f;

    void Start()
    {
        // Reset lives and score on start
        lives = 4;
        score = 0.0f;
    }

    void Update()
    {
        // Update UI 
        DisplayLives();
        DisplayScore();

        // Game Over
        if (lives <= 0)
            DoGameOver();
    }

    public static void UpdateLives(int value)
    {
        lives += value;
    }

    public static void UpdateScore(float value)
    {
        score += value;
    }

    public static float GetScore()
    {
        return score;
    }

    private void DisplayLives()
    {
        livesText.text = "Lives: " + lives.ToString("0");
    }

    private void DisplayScore()
    {
        scoreText.text = "Score: " + score.ToString("0");
    }

    private void DoGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
