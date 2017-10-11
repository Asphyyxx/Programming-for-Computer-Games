using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // creates 3 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;

    void NextGuess()
    {
        print("Is the number greater or smaller than" + guess + "?");
        print("UP: Greater Down: Smaller Enter: Equal");
    }

    void StartGame()
    {
        // prints once to the console
        print("Welcome to Number Wizard";
        print("Please choose a number in your head between" + min + "and" + max);
        NextGuess();
    }
    // Use this for initialization
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            // Calling the next guess method
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            print("Is the number greater or smaller than" + guess + "?");
            print("UP: Greater Down: Smaller Enter: Equal");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
         {
            print("Enter key pressed");
            print("Congratulations, you guessed the correct number which was:" + guess);
        }
    }
}


