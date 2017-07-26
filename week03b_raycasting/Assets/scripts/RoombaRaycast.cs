using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this will be a simple Roomba bot AI steering script to practice raycasting
public class RoombaRaycast : MonoBehaviour {
	
	void Update () {
		// 1. raycast in front of us...

		// 1a. construct the ray
		Ray ray = new Ray( transform.position, transform.forward );
		Debug.DrawRay( ray.origin, ray.direction * 3f, Color.yellow ); // visualize raycast

		// 1b. shoot the raycast for 3 units
		if (Physics.Raycast( ray, 3f )) {
			// 2. if the raycast was TRUE, there's a wall in front, so randomly turn left or right
			float randomNumber = Random.Range( 0f, 100f); // a random number from 0-100
			if (randomNumber < 50f) { // 50% chance to turn left
				transform.Rotate( 0f, -90f, 0f );
			} else { // 50% chance to turn right
				transform.Rotate( 0f, 90f, 0f );
			}
		} else {
			// 3. else, if the raycast was FALSE, there is nothing in front of us, so move forward
			transform.Translate( 0f, 0f, 5f * Time.deltaTime ); // Time.deltaTime makes it framerate independent
		}

	}
}
