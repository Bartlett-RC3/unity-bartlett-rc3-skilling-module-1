using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2_19 : MonoBehaviour {

    // Some data
    string[] tubeStation = { "Victoria", "Westminster", "Euston", "Brixton" };
    List<float> numberContainer = new List<float>();

	// Use this for initialization
	void Start () {
        Debug.Log(tubeStation[2]);

        //Debug.Log(tubeStation[6]);

        // LOOPING
        // For loop (counter, how long we count, step size)
        for (int counter = 0; counter < tubeStation.Length; counter = counter + 1){
            Debug.Log("Tube stations is London: " + tubeStation[counter]);
        }

        int sum = 0;
        for (int i = 0; i < 100; i++){
            sum = sum + i;
        }
        Debug.Log("Sum funky addtion is equal to: " + sum.ToString());

        //Shorthand for loop (in a data list/array for each item do someting
        string catchPhrese = "Tubes are bad in this stations: ";
        foreach(string tubeName in tubeStation){
            catchPhrese = catchPhrese + tubeName + " ";
        }
        Debug.Log(catchPhrese);

        // While loop (needs a condtion to stop)
        int whileCounter = 0;
        while(whileCounter < 100){
            Debug.Log("Theory is awesome? Really? Yes! Maybe!...");
            whileCounter++;
        }

        // Questioning what we do...
        // If statment (when a condition is met

        /*
        for (int j = 0; j < 100; j++){
            float randomNumber = Random.RandomRange(float.MinValue, float.MaxValue);
            numberContainer[j] = randomNumber;
        }

        int leftWins = 0;
        int rightWins = 0;
        for (int i = 0; i < numberContainer.Count-1; i++){
            int j = i + 1;
            if(numberContainer[i] > numberContainer[j]){
                Debug.Log("Left");
                leftWins++;
            } 
            else {
                Debug.Log("Right");
                rightWins++;
            }
        }

        if (leftWins > rightWins) Debug.Log("******WINNER IS******" + "LEFT");
        else Debug.Log("******WINNER IS******" + "RIGHT");

        */

        // Asking multiple questions
        bool question1 = true;
        bool question2 = true;
        bool question3 = false;

        // Concatenation
        if (question1 && question2){
            // Action here
        }

        // Or question
        if(question1 || question2){
            // Action here
        }

        // More than 2
        if(question1 || question2 || question3){
            // Action here
        }

        // Question in question
        if(question1 == true){
            if(question2 == true){
                if(question3 == false){
                    // Wow, so many questions!!!!
                }
            }
        }
    }




    // Update is called once per frame
    void Update () {
		
	}
}
