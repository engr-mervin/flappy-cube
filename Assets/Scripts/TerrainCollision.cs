using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCollision : MonoBehaviour
{
    public AudioSource collisionSound;

    void OnCollisionEnter(Collision collisionInfo)

    {
        if (collisionInfo.collider.name == "Player")
        {

            collisionSound.Play();

        }
    }
}
