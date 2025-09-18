using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameState : MonoBehaviour
{
    private static float score = 0.0f;

    public static void UpdateScore(float value)
    {
        score += value;
        print($"Score: {score}");
    }
}
