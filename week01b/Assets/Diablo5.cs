using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// we want to talk to a Text UI component
using UnityEngine.UI; // this line let's us do it

public class Diablo5 : MonoBehaviour {

	public Text myTextDisplay; // remember: don't forget to assign in Inspector!

	int myPoints;
	bool isCheatModeEnabled;
	
	// Update is called once per frame
	void Update () {
	//	myTextDisplay.text = Time.time.ToString(); // change Text display to current time

		// tap SPACE a lot to win
		// every time you tap SPACE, you get 1 point
		if (Input.GetKeyDown( KeyCode.Space )) { // use GetKeyDown to force user to release the key
			// all of these lines of code do the same thing
		//	myPoints = myPoints + 1;
			myPoints += 1;
		//	myPoints++; // increments by one
		}

		// display the current numbers of points
		myTextDisplay.text = "WELCOME TO DIABLO 5! GET POINTS TO WIN!\ncurrent points: " + myPoints.ToString();


		// press [C] on keyboard to activate Cheat Mode
		if (Input.GetKeyDown( KeyCode.C )) {
			isCheatModeEnabled = true;
		}

		// if cheat mode is on, then automatically give me points every frame
		if (isCheatModeEnabled == true) {
			myPoints += 5;
		}


	}
}
