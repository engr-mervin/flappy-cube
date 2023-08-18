
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody rb;
    void OnTriggerEnter(Collider collider)
    {
        if (gameManager.GameHasEnded == false&&collider.name == "Player")
        {
            gameManager.CompleteLevel();
            rb.AddForce(0, 0, 8000);
        }


    }
}
