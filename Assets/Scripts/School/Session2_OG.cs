using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3Students;

public class Session2_OG : MonoBehaviour {

    // Variables

    int number1 = 10;
    int number2 = 20;
    int number3;

    bool someBool = false;

    string someName = "name";

    string[] tutorNames = { "Dave", "Tyson", "Jordi", "Octavian", "Panos" };

    List<Student> RC2018 = new List<Student>();

	// Use this for initialization
	void Start () {

        Student Bangrui = new Student("Bangrui", "Null", "Chen", 24, "China");

        Debug.Log(Bangrui.GetStudentName());

        Debug.Log("A tutor is: " + tutorNames[0]);
        Debug.Log("A tutor is: " + tutorNames[1]);
        Debug.Log("A tutor is: " + tutorNames[2]);

        // Navigate data using loops

        // Iterative for loop
        // For loop (variables that counts start, where it ends, what is the incerment
        for (int i = 0; i <= tutorNames.Length - 1; i++){
            Debug.Log("A tutor is: " + tutorNames[i]);
        }

        for (int counter = 0; counter <= number2; counter++){
            Debug.Log("Counting..." + counter);
        }

        // For each loop
        foreach(string tutorName in tutorNames){
            Debug.Log(tutorName);
        }

        // Condtions
        if (number1 < number2){ // Question
            // Action if true
            Debug.Log("Number 1 is smaller than number 2");
        } else {
            // Action if false
            Debug.Log("Number 2 is smaller than number 1");
        }

        // Questions we can ask
        // If something is smaller or bigger
        // <, >, <=, >=

        // If somering is equal to soemthing else
        // ==, !=

        // Asking multiple question
        if(number1 < number2 && someBool == true ){
            // Action
            Debug.Log("Answer to both questions is yes!");
        }

        if(number1<number2){
            if(someBool == true){
                Debug.Log("Answer to both questions is yes!");
            }
        }

        if(number1<number2 || someBool == true){
            Debug.Log("Answer to one of the questions was true");
        }

        // Complex question by concatenation and by emdedding sub questions
        if((number1<number2 && someBool == true) && (someBool == true && someName == "name")){

            Debug.Log("This is too confusing! Simply please!");
        }

        // Shorthand if
        number3 = (number1 < number2) ? 100 : 200;


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
