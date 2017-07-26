using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour {

	public float moveSpeed = 5f;

	void Update () {
		// tell fish to always swim forward
		transform.Translate( 0f, 0f, moveSpeed * Time.deltaTime );

		// an alternate way of moving forward, if you want:
		// transform.position += transform.forward * Time.deltaTime * moveSpeed;

		// randomly turn
		if (Random.Range( 0f, 100f ) > 99f) { // ~1% chance
			transform.Rotate( 0f, Random.Range(-360f, 360f), 0f );
		}
	}
}
