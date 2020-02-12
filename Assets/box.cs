using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
	enum GravityDirection { Down, Left, Up, Right };
    GravityDirection m_GravityDirection;

    void Start()
    {
        m_GravityDirection = GravityDirection.Up;
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

    void OnMouseDown(){
         // this object was clicked - do something
            Destroy (this.gameObject);
    }  
}
