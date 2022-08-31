using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject gameOverCanva;
    public GameObject playButtonCanva;
    public GameObject titleCanva;
    private int score;

    public void IncreaseScore()
    {
        score++;
    }

    private void Start() 
    {
        titleCanva.SetActive(false);
        gameOverCanva.SetActive(false);
        playButtonCanva.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        titleCanva.SetActive(false);
        gameOverCanva.SetActive(true);
        playButtonCanva.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
