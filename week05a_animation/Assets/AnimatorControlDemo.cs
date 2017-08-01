using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControlDemo : MonoBehaviour {

	Animator myAnimator;

	void Start () {
		myAnimator = GetComponent<Animator>(); // cache reference to the Animator component
	}

	void Update () {
		// is the player holding down SPACEBAR? if so, then bounce; if not, don't bounce
		if (Input.GetKey( KeyCode.Space )) {
			// enable bouncing
			myAnimator.SetBool( "isBouncing", true );
		} else {
			// disable bouncing
			myAnimator.SetBool( "isBouncing", false );
		}

	}

}
