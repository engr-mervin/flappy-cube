
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int score;
    public GameManager gameManager;
    public Text highScore;
    public Text endScore;
    public Text gameOverScore;
    public GameObject gameOverUI;
    public GameObject inGameUI;

    // Update is called once per frame
    void Update()
    {

        if (gameManager.GameHasEnded == false && gameManager.EndLevel == false)
        {
            if (player.position.z >= 0)
            {
                score = Convert.ToInt32(player.position.z);
                scoreText.text = score.ToString("0");
            }
            else
            { 
                score = 0;
                scoreText.text = "";
            }

        

          
        }

        if (gameManager.GameHasEnded == true)
        {
            
            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                Debug.Log("ok");
                PlayerPrefs.SetInt("HighScore", score);
                PlayerPrefs.Save();
                gameOverScore.text = "New High Score!: " + score.ToString("0");
                gameOverUI.SetActive(true);
                inGameUI.SetActive(false);


            }
            else
            {
                Debug.Log("ok");
                gameOverScore.text = "Score: " + score.ToString("0");
                gameOverUI.SetActive(true);
                inGameUI.SetActive(false);
            }
        }

        if (gameManager.GameHasEnded == false && gameManager.EndLevel == true)
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
            endScore.text = "Score: " + score.ToString("0");
        }
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
