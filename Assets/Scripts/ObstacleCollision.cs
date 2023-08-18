using UnityEngine;



public class ObstacleCollision : MonoBehaviour
{
    public AudioSource collisionSound;

    void OnCollisionEnter(Collision collisionInfo)

    {
        if (collisionInfo.collider.name == "Player" || collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.name == "Terrain")
        {

            collisionSound.Play();

        }
    }
}
