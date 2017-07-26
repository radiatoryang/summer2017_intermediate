using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingRaycast : MonoBehaviour {

	public Transform paintGlob; // the thing I'm painting with

	void Update () {
		// 1. construct the ray based on mouse cursor position on screen
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );

		// 2. reserve space in memory to store raycast impact info
		RaycastHit rayHit = new RaycastHit(); // right now, this is a blank variable

		// optional: visualize the raycast
		Debug.DrawRay( ray.origin, ray.direction * 100f, Color.yellow );

		// 3. shoot the raycast
		if (Physics.Raycast( ray, out rayHit, 100f )) {
			// 4. do stuff with our paintGlob
			// paintGlob.position = rayHit.point; // RaycastHit.point = world position where the raycast hit a thing
		
			// 5. instantiate a new paintGlob clone where the raycast hit
			Instantiate( paintGlob, rayHit.point, Quaternion.Euler(0f, 0f, 0f) );
		}
	}
}
