using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverSceneScript : MonoBehaviour
{
    public Text finalScoreText;

    void Update()
    {
        // Final Score
        finalScoreText.text = "Final Score: " + GameState.GetScore().ToString("0");

        // Back to title
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScene");
        }  
    }
}
