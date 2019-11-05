using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3_19 : MonoBehaviour {

    public GameObject robotPrefab;
    public int noRobots = 10;

	// Start function is run just once at the beginning of the game
	void Start () {
        // We will make randomly new robots in the scene
        for (int i = 0; i < noRobots; i++){
            //Make a random position and random rotation
            Vector3 robotPos = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
            Quaternion robotRot = Quaternion.identity;
            GameObject newRobot = Instantiate(robotPrefab, robotPos, robotRot);
            Transform robotHead = newRobot.transform.GetChild(0);
            robotHead.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
	}
	
	// Update is called once per frame as fast as possible
	void Update () {
		
	}
}
