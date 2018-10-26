using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3_OG : MonoBehaviour {

    public GameObject cubePrefab;
    public GameObject light;
    public GameObject objectReference;
    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;


    // Use this for initialization
    void Start () {
		for(int i=0; i< gridX; i++)
        {
            for(int j=0; j< gridY; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity,this.transform);
            }
        }

        
	}
	
	// Update is called once per frame
	void Update () {
        objectReference.transform.Translate(Vector3.up);
        // TIME
        Debug.Log("This computer can render a frame in: " + Time.deltaTime);
        Debug.Log("Since I started playing the game this amount of time has passed:" + Time.timeSinceLevelLoad);
        Debug.Log("Computer has counted this ammount of frames:" + Time.frameCount);

        // TRANSLATION
        // Move children gameobjects in x axis
        foreach(Transform child in this.transform)
        {
            child.Translate(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f,0.1f));
        }

        // ROTATION
        // Rotate children gameobjects around y axis
        foreach (Transform child in this.transform)
        {
            child.RotateAroundLocal(Vector3.up, Random.value);
        }

        // SCALING
        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), Random.Range(0.1f, 1));
        }

        // Record the cubes orginal scale
        Vector3[] originalScale = new Vector3[this.transform.childCount];
        for(int i =0; i<transform.childCount; i++)
        {
            originalScale[i] = transform.GetChild(i).localScale;
        }
        // KEYBOARD INPUT
        if (Input.GetKey(KeyCode.Space))
        {
            // If I have pressed space make temporary the cubes large!
            foreach (Transform child in this.transform)
            {
                child.localScale = child.localScale * 5f;
            }
        } else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localScale = originalScale[i];
            }
        }

        // MOUSE PRESSED (O left, 1 right, 2 middle)
        if (Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
        }


    }
}
