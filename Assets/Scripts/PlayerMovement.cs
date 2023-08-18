
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce;
    public float sidewaysForce;

    public bool moveLeft = false;
    public bool moveRight = false;

    private float screenWidth = Screen.width;



    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            if(FindObjectOfType<GameManager>().gameisPaused == false)
            FindObjectOfType<AudioManager>().Play("Controls");

            moveRight = true;
        }
        if (Input.GetKeyUp("d"))
            moveRight = false;

        if (Input.GetKeyDown("a"))
        {
            if (FindObjectOfType<GameManager>().gameisPaused == false)
            FindObjectOfType<AudioManager>().Play("Controls");

            moveLeft = true;
        }

        if (Input.GetKeyUp("a"))
            moveLeft = false;

        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).position.x > screenWidth / 2)
            {
                moveRight = true;
                moveLeft = false;

                if (FindObjectOfType<GameManager>().gameisPaused == false)
                { 
                FindObjectOfType<AudioManager>().Play("Controls");
                }
    
            }

            if (Input.GetTouch(0).position.x < screenWidth / 2)
            {
                moveRight = false;
                moveLeft = true;

                if (FindObjectOfType<GameManager>().gameisPaused == false)
                {
                    FindObjectOfType<AudioManager>().Play("Controls");
                }

            }

        }
    }
   
   
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight == true)
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        if (moveLeft == true)
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        if(rb.position.y<-0.5f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
