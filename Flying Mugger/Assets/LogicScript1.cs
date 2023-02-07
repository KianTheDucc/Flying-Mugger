using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject TheMugger;
    public GameObject PipeSpawner;
    public GameObject StartScreen;
    public Text GameOverText;
    public GameObject Score;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        playerScore += PipeMiddleScript.scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        TheMugger.SetActive(false);
        PipeSpawner.SetActive(false);
        StartScreen.SetActive(false);
        GameOverText.text = "Game Over! Score: " + playerScore.ToString();
        gameOverScreen.SetActive(true);
        Score.SetActive(false);
        
    }

    public void StartGame()
    {
        TheMugger.SetActive(true);
        PipeSpawner.SetActive(true);
        StartScreen.SetActive(false);

    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
