using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHandler : MonoBehaviour {

    private bool up;
    private bool move;

	// Use this for initialization
	void Start () {
        up = false;
        move = true;
	}
	
	// Update is called once per frame
	void Update () {
        // TIME
        // Rotate Robot every 5 seconds and randomly move forward
        if(Time.frameCount % 10 == 0 && move == true){
            this.transform.RotateAround(transform.position, Vector3.up, Random.Range(-180, 180));
            this.transform.Translate(Vector3.forward * Random.Range(1.0f, 5.0f), Space.Self);
        }

        // KEYBOARD INPUT
        if(Input.GetKeyDown(KeyCode.Space)){
            Transform rightHand = this.transform.GetChild(3);
            if(up == false){
                rightHand.Rotate(new Vector3(0, 0, 90), Space.Self);
                up = true;
            } else {
                rightHand.Rotate(new Vector3(0, 0, -90), Space.Self);
                up = false;
            }
        }

        // MOUSE INPUT
        if(Input.GetMouseButtonDown(0)){
            move = !move;
        }

	}
}
