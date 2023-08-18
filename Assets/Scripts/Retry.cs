using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Retry : MonoBehaviour
{

    public PlayerMovement movement;
    public GameObject MenuUI;
    public GameObject gameOverUI;

    // Start is called before the first frame update
    public void RetryClicked()
    {
        SceneManager.LoadScene("Game without Menu");
        
    }
    public void MenuClicked()
    {
        SceneManager.LoadScene("Game");

    }

}
