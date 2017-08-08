using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshake : MonoBehaviour {

	Camera myCamera; // camera to shake

	// "public static" makes this into a "global" variable
	public static float shakeStrength = 0f;

	// Use this for initialization
	void Start () {
		myCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		// pick a random direction to shake towards
		Vector3 shakeOffset = Random.onUnitSphere;
		shakeOffset.z = Mathf.Clamp( shakeOffset.z, 0f, 0.5f); // tweak the Z direction of the shaking

		// use Lerp to smoothly move the Camera's local position to a random vector
		myCamera.transform.localPosition = 
			Vector3.Lerp( 
				myCamera.transform.localPosition, 
				shakeOffset * shakeStrength,
				Time.deltaTime * 0.5f
			);

		// constantly decay "shakeStrength"
		shakeStrength = Mathf.Clamp(shakeStrength - Time.deltaTime, 0f, 5f); 

		// test key for testing shake strength
		if (Input.GetKeyDown( KeyCode.Space )) {
			Screenshake.shakeStrength = 5f;
		}
	}
}
