using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public Text livesText;
    public Text scoreText;
    public Text enemyCountText;
    private static int lives = 4;
    private static float score = 0.0f;
    private static int enemyCount = 0;


    void Start()
    {
        // Reset lives and score on start
        lives = 4;
        score = 0.0f;
        enemyCount = 0;
    }

    void Update()
    {
        // Update UI 
        DisplayLives();
        DisplayScore();
        DisplayEnemyCount();

        // Game Over
        if (lives <= 0)
            DoGameOver();
        // Game Won
        if (enemyCount == 100)
            GameWon();
    }

    public static void UpdateLives(int value)
    {
        lives += value;
    }

    public static void UpdateScore(float value)
    {
        score += value;
    }

    public static void IncreaseEnemyCount()
    {
        enemyCount++;
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

    private void DisplayEnemyCount()
    {
        enemyCountText.text = enemyCount.ToString("0") + " / 100";
    }

    private void DoGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    private void GameWon()
    {
        SceneManager.LoadScene("VictoryScene");
    }
}
