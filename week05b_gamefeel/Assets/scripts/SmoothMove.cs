using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMove : MonoBehaviour {

	public Transform cube; // the sphere will always move towards the cube

	void Update () {
		// move towards the cube at 5 units / sec, with linear acceleration
		// transform.position = Vector3.MoveTowards( transform.position, cube.position, Time.deltaTime * 5f );

		// move towards the cube but SMOOTHLY, easing in and out
		// x += (target - x) * 0.1f
		transform.position += (cube.position - transform.position) * 5f * Time.deltaTime;
		transform.position = Vector3.Lerp( transform.position, cube.position, 5f * Time.deltaTime );
	}
}
