
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.EndLevel == false)
        {
            transform.position = player.position + offset;
        }
       
    }
}
