using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1_OG : MonoBehaviour {

    // 1.Variables
    // Scope -- Type -- Name -- Value (just one value)

    // Numbers
    public int myInteger = 145;
    int largestInteger = int.MaxValue;
    int smallestIntege = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    float myFloat = 32.456f;

    // Text
    string myString = "This is the new awesome RC3! Better tahn ever :)";

    // Logical 
    bool myBoolean = true;
    bool falseBoolean = false;

    // 2. Data structures
    // Scope -- Type -- Values (can take in many values)

    // Array
    public int[] myIntArrary = { 1, 2, 3, 4, 5, 6 };
    int[] twentyElementsArray = new int[20];
    int[,] xyArray = new int[4, 5];

    double[] doubleArray = { 10.4, 11.23, 45, 72.9 };

    // List
    List<int> myList = new List<int>();

    // Dictionary
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();


    // 3.Functions
    // Scope -- Type -- Variables -- Body (Instructions)

    // Use this for initialization
    void Start () {
        // Arrray adding values
        myIntArrary[2] = 300;

        // Array retrive value
        Debug.Log(myIntArrary[1].ToString());

        // List adding values
        myList.Add(4321);
        myList.Add(41);
        myList.Add(1);

        // List retrive values
        Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count-1].ToString());

        // Clearing the list
        myList.Clear();

        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("flying", "parrot");
        movingAnimals.Add("walking", "human");
        movingAnimals.Add("walking", "dog");

        if(movingAnimals.ContainsKey("flying")){
            Debug.Log("A flying animal is:" + movingAnimals.Values);
        }

    }
	
	// Update is called once per frame
	void Update () {


        myFloat = 13.4f;
    }

    // Number addtion function
    // Scope -- Type-- Variables -- Body(Instructions)
    float NumberAddition(float a, float b)
    {
        float additionResult = a + b;
        return additionResult;
    }


}
