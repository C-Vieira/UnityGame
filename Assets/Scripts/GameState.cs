using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    public Text scoreText;
    private static float score = 0.0f;

    void Start()
    {
        // Reset score on start
        score = 0.0f;
    }

    void Update()
    {
        // Update score visuals
        DisplayScore();
    }

    public static void UpdateScore(float value)
    {
        score += value;
    }

    private void DisplayScore()
    {
        scoreText.text = "Score: " + score.ToString("0");
    }
}
