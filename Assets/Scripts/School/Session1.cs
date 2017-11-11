//Refrences 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Where code lives 
public class Session1 : MonoBehaviour {

    // 1.Variables
    // Scope -- Type -- Name -- Value

    // Numbers
    public int myFirstIntegerNumber = 101; //make sure you end with ;
    float myFirstFloatNumber = 1.75f;

    // Text
    public string myFirstString = "My text is somewhere.";

    // Logical variable
    bool myFirstBoolean = true;

    // Data structures
    // Scope -- Type -- Values

    // 3.a.Arrays
    public int[] myIntegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    // 3.b.Lists
    public List<int> myIntegerList = new List<int>();

    // 2.Functions
    // Scope -- Type -- Variables -- Body (Instructions)

    // Use this for initialization
    void Start () {
        Debug.Log("Addition of 5 and 3 is: " + AddtionOfNumbers(5,3));
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.6f;
        myFloatArray[4] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Hello world!");
	}

    int AddtionOfNumbers(int number1, int number2)
    {
        int addtionResult = number1 + number2;
        return addtionResult;
    }
}
