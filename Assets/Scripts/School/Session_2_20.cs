// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CLASS(es)

public class Session_2_20 : MonoBehaviour
{
    // Colour Names Array
    string[] colours = { "red", "green", "blue", "yellow", "fuchsia" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(colours[1]);

        // LOOPS
        // For loop (counter, end condition, step)
        for (int counter = 0; counter < colours.Length; counter = counter + 1)
        {
            Debug.Log("The current color at pos " + counter);
            Debug.Log(" " + colours[counter]);
        }

        int sumOfOddNumbers = 0;
        for (int i = 1; i < 100; i = i + 2)
        {
            sumOfOddNumbers += i;
        }
        Debug.Log("All odd numbers to 100 added togheter is:" + sumOfOddNumbers);

        // Shorthand for loop
        foreach (string currrentColour in colours)
        {
            Debug.Log("Going over the rainbow with " + currrentColour);
        }

        // While loop (needs a condtion to end)
        int whileCounter = 0;
        string rainbow = "Rainbow colours: ";
        while (whileCounter < colours.Length)
        {
            rainbow += colours[whileCounter] + ",";
            whileCounter += 2;
        }
        Debug.Log(rainbow);

        // CONDITIONALS (asking the computer questions)

        // If statement (has 2 branches, one for true, one for false, false branch is optional)
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Whole number:" + i);
            }
            else
            {
                Debug.Log("Odd number" + i);
            }
        }

        // Asking multiple questions
        bool question1Answer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        // Two condtions met (Concatenation)

        if (question1Answer && question2Answer)
        {
            Debug.Log("Both answers are true");
        }

        // One codition is met from 2 questions (Or question)
        if (question1Answer || question3Answer)
        {
            Debug.Log("One of the answers is true");
        }

        // More than 2 questions
        if (question1Answer || question2Answer || question3Answer)
        {
            // Action here
        }

        // Question in question
        if(question1Answer == true)
        {
            if(question2Answer == true)
            {
                if(question3Answer == false)
                {
                    // Action here
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
