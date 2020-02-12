using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character : MonoBehaviour
{
    private double lastInterval;

    enum GravityDirection { Down, Left, Up, Right };
    GravityDirection m_GravityDirection;

    void Start()
    {
        m_GravityDirection = GravityDirection.Up;
        lastInterval = Time.realtimeSinceStartup;

    }

    void Update()
    {
        switch (m_GravityDirection)
        {
            case GravityDirection.Down:
                //Change the gravity to be in a downward direction (default)
                Physics2D.gravity = new Vector2(0, -9.8f);
                //Press the space key to switch to the left direction
                break;

            case GravityDirection.Left:
                //Change the gravity to go to the left
                Physics2D.gravity = new Vector2(-9.8f, 0);
                //Press the space key to change the direction of gravity
                break;

            case GravityDirection.Up:
                //Change the gravity to be in a upward direction
                Physics2D.gravity = new Vector2(0, 9.8f);
                //Press the space key to change the direction
                break;

            case GravityDirection.Right:
                //Change the gravity to go in the right direction
                Physics2D.gravity = new Vector2(9.8f, 0);
                //Press the space key to change the direction

                break;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_GravityDirection = GravityDirection.Left;
            Debug.Log("Left");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_GravityDirection = GravityDirection.Up;
            Debug.Log("Up");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_GravityDirection = GravityDirection.Right;
            Debug.Log("Right");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_GravityDirection = GravityDirection.Down;
            Debug.Log("Down");
        }

    }


    void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.tag == "Respawn") {
            PlayerPrefs.SetString ("lastLoadedScene", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(6);
        }
    }



    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Finish")) {
            float timeNow = Time.realtimeSinceStartup;
            int y = SceneManager.GetActiveScene().buildIndex;
            Debug.Log("Level " + y + " complete time:" + (timeNow-lastInterval));

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
            SceneManager.LoadScene(y+1);
        }
            
    }
}


