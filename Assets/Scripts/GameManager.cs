using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 2f;

    public GameObject levelCompleteUI;

    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
    }

    public void GameOver()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
