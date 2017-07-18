using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTestMove : MonoBehaviour {

	Rigidbody rb;
	Vector3 input;
	float rotationY;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3( Input.GetAxis( "Horizontal" ), 0f, Input.GetAxis( "Vertical" ) );

		transform.Rotate( 0f, Input.GetAxis( "Mouse X" ) * Time.deltaTime * 90f, 0f );
		rotationY = Mathf.Clamp( rotationY - Input.GetAxis("Mouse Y") * Time.deltaTime * 90f, -80f, 80f );
		Camera.main.transform.localEulerAngles = new Vector3(rotationY, 0f, 0f);

		if (Input.GetKey( KeyCode.Space )) {
			input.y = 2f;
		}
	}

	void FixedUpdate () {
	//	rb.MovePosition( transform.position + transform.TransformDirection( input ) * 0.5f );

		bool grounded = Physics.Raycast( transform.position, Vector3.down, 1.1f );

		if (grounded) {
			rb.velocity = transform.TransformDirection( input ) * 5f;
		} else {
			rb.AddForce( Physics.gravity );
		}
	}
}
