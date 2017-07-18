using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonRigidBody : MonoBehaviour {

	// "public" exposes the variable to the Unity inspector
	public float mouseSensitivity = 180f;
	public float moveSpeed = 10f; 

	Vector3 inputVector; // this variable passes data from Update > FixedUpdate
	Rigidbody rbody;

	float mouseY; // for accumulating Mouse Y data, so we clamp it before applying the rotation

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>(); // cache reference to Rigidbody
	}
	
	// Update is called once per frame
	// always put input / rendering in regular Update
	void Update () {
		// keyboard movement
		inputVector.x = Input.GetAxis( "Horizontal" );
		inputVector.y = -0.5f;
		inputVector.z = Input.GetAxis( "Vertical" );

		// mouse look
		transform.Rotate( 0f, Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity, 0f );
		mouseY -= Input.GetAxis( "Mouse Y" ) * Time.deltaTime * mouseSensitivity;
		mouseY = Mathf.Clamp( mouseY, -60f, 60f ); // clamp vertical mouse look
		Camera.main.transform.localEulerAngles = new Vector3( mouseY, 0f, 0f ); // apply up-down movement
	
		// hide the mouse cursor, for better first person game feel
		if ( Input.GetMouseButtonDown(0) ) { // 0 = left-click, 1 = right-click, 2 = middle-click
			Cursor.lockState = CursorLockMode.Locked; // locks cursor to middle of screen
			Cursor.visible = false; // actually hides the cursor
		}
	}

	// FixedUpdate runs on a fixed interval with the PhysX
	// always put physics code in FixedUpdate
	void FixedUpdate () {
		// convert inputVector from local space into world space
		// "transform.right" is the capsule's current "right", etc.
		// we also could've done this all with one line via "transform.TransformDirection( inputVector );"
		Vector3 worldVector = 
			  transform.right * inputVector.x 
			+ transform.forward * inputVector.z
			+ transform.up * inputVector.y;

		// AddForce is good for movement that IS NOT walking
		// rbody.AddForce( worldVector * moveSpeed, ForceMode.VelocityChange ); // actually apply the force now
		// ^ commented out for now
	
		// set velocity directly = is good for walking, or movement where you need to stop instanteously
		rbody.velocity = worldVector * moveSpeed;
	}



}
