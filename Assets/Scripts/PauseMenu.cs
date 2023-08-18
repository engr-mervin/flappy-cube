using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
   
    public static bool GameIsPaused=false;
    public GameObject PauseMenuUI;
    public AudioSource drivingSound;

    // Update is called once per frame
    public void PausedClicked()
    {
        if (GameIsPaused==false)
        {
            GameIsPaused = true;
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            drivingSound.enabled = false;
            FindObjectOfType<GameManager>().gameisPaused = true;
            
        }

        
    }
    public void Resume()
    {
        if (GameIsPaused == true)
        {
            GameIsPaused = false;
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            drivingSound.enabled = true;
            FindObjectOfType<GameManager>().gameisPaused = false;
        }



    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        
    }
}
