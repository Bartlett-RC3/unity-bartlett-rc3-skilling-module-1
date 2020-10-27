// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODE STRUCTURE
public class Session_1_20 : MonoBehaviour
{
    // 1.VARIABLES - data that is stored in your computer memory

    // Declaring Variables: Scope (visibility) -- Type -- Name -- Value (optional)

    // Numbers
    public int myFirstWholeNumber = 1;
    private int mySecondWholeNumber = 99;

    public float myFirstDecimalNumber = 1.1234567890123456f;

    public double myFirstLongDecimalNumber = 1.12345678901234561234567890123456d;

    // Text
    private string myFirstWords = "Hello RC3 and RC9! Happy to teach you this!";
    public string mySecondWord = "Hello!";

    // Logical (binary can be either true or false)
    private bool myFristBoolean = false;
    public bool mySecondBoolean = true;

    // 2.DATA STRUCTURES

    // Declaring Data Structures: Scope -- Type -- Name -- Values (optional)

    // Arrays
    public int[] myWholeNumbersCollection = new int[5];
    public float[] myDecimalNumbersCollection = { 1.3f, 2.5f, 3.0f };

    // Lists
    public List<int> myFirsIntList = new List<int>();

    // 3.FUNCTIONS

    // Declaring Functions: // Scope -- Type -- Variables -- Body (Instructions)

    private float CalculatorSum (float _FirstNumber, float _SecondNumber)
    {
        float SumResult = _FirstNumber + _SecondNumber;
        return SumResult;
    }

    // Start is called before the first frame update
    void Start()
    {
        float SumResult = CalculatorSum(myFirstWholeNumber, mySecondWholeNumber);
        Debug.Log("Adding two numbers result is: " + SumResult.ToString());

        // Data in Arrays
        // Changing the data
        myDecimalNumbersCollection[0] = 2.8f;
        // Retriving the data
        float SumResult2 = CalculatorSum(myDecimalNumbersCollection[0], myDecimalNumbersCollection[2]);

        // Data in Lists
        // Changing the data
        myFirsIntList.Add(3);
        myFirsIntList.Add(9);
        myFirsIntList[0] = 5;
        myFirsIntList[1] = 12;
        // Retriving the data
        Debug.Log(myFirsIntList[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
