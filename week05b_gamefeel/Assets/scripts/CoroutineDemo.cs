using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// YOU MUST START A COROUTINE WITH "STARTCOROUTINE"
		StartCoroutine( MyFirstCoroutine() );
	}
	
	// a coroutine = a function where we can control how fast it runs / how long it runs
	// coroutines in Unity must inherit from "IEnumerator"
	IEnumerator MyFirstCoroutine () {
		Debug.Log( "the coroutine started!" );
		yield return 0; // pause for 1 frame
		Debug.Log( "ok, finished waiting! continuing now...");
		yield return 0;
		yield return 0; // waiting for 2 frames... "yield return 1" will wait for 1 frame!!
		Debug.Log( "ok, waited for 2 more frames!... continuing now!");

		// use WaitForSeconds to wait for an amount of time
		yield return new WaitForSeconds(1f);
		Debug.Log( "I waited for 1 more second before printing this message!" );

		// this is useful for scripting logic
		// NPC: "hello, adventurer!";
		// WaitForSeconds(1f);
		// NPC: move towards the player
		// NPC: "save the magic crystals!";

		// pause coroutine until player presses SPACE
		while (Input.GetKeyDown( KeyCode.Space ) == false) {
			yield return 0; // keep waiting as long as player doesn't press SPACE
		}
		// when player presses space, it exits this WHILE loop and continues...

		// tell this coroutine to wait until another coroutine ends
		yield return StartCoroutine( WaitFor10SecondsCoroutine() );

		// after the coroutine finishes, we continue...

		// when we reach t end of a coroutine, nothing left to do... it terminates automatically

		// but if we wanted to manually end the coroutine at any time, we can say "yield break"
		yield break;
	}

	IEnumerator WaitFor10SecondsCoroutine () {
		yield return new WaitForSeconds(10f);
	}

}
