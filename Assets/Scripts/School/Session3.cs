using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3 : MonoBehaviour {

    // Variables
    int counter = 0;
    public GameObject cubeReference;
    bool moveLeft = true;
    bool moveRight = false; 

    // Use this for initialization
    void Start () {
       	
	}
	
	// Update is called once per frame
	void Update () {
        // Time in frames, not very useful because of variation 
        /*
        counter = counter + 1;
        if (counter % 30 == 00){
            Debug.Log("Time in frames is: " + counter/30);
        }
        */
        
        // Time in milliseconds, useful because it is precise
        Debug.Log("Actual time is: " + Time.deltaTime.ToString());

        /*
        // Move cube left and right by manually setting the Transform component
        if(moveLeft == true)
        {
            if(counter <= 15)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter*(-1), 0, 0);
                counter++;
            } else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if(moveRight == true)
        {
            if(counter <= 15)
            {
                gameObject.transform.Translate(Vector3.left);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }
        }
        */

        // Use Unity built-in functions to move the cube left and right
        if (moveLeft == true)
        {
            if (counter <= 15)
            {
                gameObject.transform.Translate(Vector3.left);
                counter++;
            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = 0;
            }
        }
        if (moveRight == true)
        {
            if (counter <= 15)
            {
                gameObject.transform.Translate(Vector3.right);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 0;
            }
        }

        // Keyboard input
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 0));
        }

        // Mouse input 
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        if(Input.GetMouseButtonDown(1))
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }
}