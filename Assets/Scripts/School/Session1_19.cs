using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1_19 : MonoBehaviour {

    // VARIABLES (How to declare below)
    // SCOPE(private/public/serialize) TYPE(int,float,dobule,bool) NAME VALUE (optional)

    // A.Individual variables

    // A1. Whole number (1,2,3,....888)
    public int number1 = 0; // SCOPE TYPE NAME VALUE
    public int number2 = 0;

    // A2. Decimal number (0.00, 1.00, 2.00,...333.33)
    [SerializeField] float decimalNumber1 = 0.01f;
    [SerializeField] float decimalNumber2;

    private double someDecimalNumber = 0.00000d;

    // A3. Logical
    private bool isItStatment = true;

    // A4. Words (english prefered, could be anything else, don`t know mandarin/cantones)
    public string myName = "Octavian";

    // B.Multiple Variables (Collections)
    // SCOPE TYPE NAME VALUES

    // B1. Array
    public string[] rc3Tutors = {"Tyson", "Octav", "Valentina"};
    public int[] threeNumbers = new int[3];
    [SerializeField] float[] someFloats = { 0.00f, 0.1f, 3.5f };

    // B2. Lists 
    // SCOPE List<TYPE> NAME INITIALIZATION 
    public List<int> myIntList = new List<int>();

    // FUNCTIONS (How to declare below)
    // SCOPE (public/private) TYPE/OUTPUT(int/double/bool,void,abstract) NAME VARIABLES(var1, var2...) INSTRUCTIONS {always between}
    private float SumCalculator(float no1, float no2){
        float sum = no1 + no2;
        return sum;
    }

    // This is a function that adds two number
    private float FastSum(float no1, float no2){
        return no1 + no2;
    }

    void FunkyFunctionOfTripleAddition()
    {
        float justSomeFloat = FastSum(FastSum(number1, number2),decimalNumber1);
        Debug.Log(justSomeFloat);
    }

    // Use this for initialization
    void Start () {
        // 4. For expert code people 
        var myVariable = 1;
        var myVariable2 = 0.00f;
        var myVariable3 = true;

        Debug.Log("Int added sum is " + SumCalculator(number1, number2));
        FunkyFunctionOfTripleAddition();

        // Getting data from an array
        float sumFromArray;
        sumFromArray = someFloats[0] + someFloats[1];
        Debug.Log(sumFromArray);

        // Adding data to a list
        myIntList.Add(33);
        myIntList.Add(11);

        // Getting data from a list
        int getInt = myIntList[0];
        Debug.Log(getInt);
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log(FastSum(number1, number2));
        }
	}
}
