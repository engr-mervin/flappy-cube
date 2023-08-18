using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    
    public void Quit()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene(0);
    }

}
