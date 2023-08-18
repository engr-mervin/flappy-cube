using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject completeGameUI;
    public bool EndLevel=false;
    public PlayerMovement movement;
    public AudioSource drivingSound;
    public bool gameisPaused = false;

    public void CompleteLevel()
    {
        Debug.Log("Level Won!");

        completeGameUI.SetActive(true);
        EndLevel = true;
        movement.enabled = false;
        FindObjectOfType<AudioManager>().Play("Complete");

    }

    public void EndGame()
    {
        if (GameHasEnded == false && EndLevel == false)
        {
             {
                Debug.Log("Game Over.");
                GameHasEnded = true;
                movement.enabled = false;
                drivingSound.enabled = false;
                

            }
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);

        
    }

}
