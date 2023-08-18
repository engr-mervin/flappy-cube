using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject MenuUI;
    public GameObject InGameUI;
    public AudioSource driveSound;

    public void StartGame()
    {
        movement.enabled = true;
        MenuUI.SetActive(false);
        InGameUI.SetActive(true);
        driveSound.enabled = true;

    }
    public void CreditsRoll()
    {
        MenuUI.SetActive(false);
        SceneManager.LoadScene("Credits");

    }
    public void Exit()
    {

        Application.Quit();
        Debug.Log("Quit");
    }
}
