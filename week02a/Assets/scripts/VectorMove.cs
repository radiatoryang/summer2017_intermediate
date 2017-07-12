using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMove : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		// GetKeyDown and GetKeyUp refer to "event", good for tapping input
		// GetKey is for holding down

		// MOVEMENT CODE
		if (Input.GetKey( KeyCode.W )) { // move forward if I press [W]
			// moved cube while IGNORING rotation
			// transform.position += new Vector3(0f, 0f, 1f); // "WORLD SPACE"

			// move cube while following rotation
			transform.Translate( 0f, 0f, 1f ); // "LOCAL SPACE"
		}

		// TURNING CODE
		if (Input.GetKey( KeyCode.A )) { // if I hold [A] button...
			transform.Rotate( 0f, -15f, 0f ); // ... rotate 15 degrees left on Y axis
		}
		if (Input.GetKey( KeyCode.D )) { // if I hold [D] button...
			transform.Rotate( 0f, 15f, 0f ); // ... rotate 15 degrees right on Y axis
		}


	}
}
