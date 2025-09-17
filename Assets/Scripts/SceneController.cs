using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController: MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameScene");
        }  
    }
}
