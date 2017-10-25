﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int min, max, guess;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won!");
            print("========================");
            StartGame();
        }
    }

    void StartGame() {
        min = 0;
        max = 1000;
        guess = 500;

        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        print("The lowest number you can pick is " + min);
        print("The highest number you can pick is " + max);

        max = (max % 2 == 0) ? ++max : max; // Integer rounding will prevent guesses of max if max is even.
                                            // Incrementing max to an odd number resolves the issue

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, Enter = equal.");
    }

    void NextGuess() {
        guess = (max + min) / 2;
        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, Enter = equal.");
    }
}
