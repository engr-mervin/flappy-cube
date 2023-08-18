
using UnityEngine;

public class MarkerTrigger : MonoBehaviour
{
   
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Marker");
        }
    }

}
