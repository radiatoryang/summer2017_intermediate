using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour {

	CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		// gets our input from Unity's virtual joysticks
		float horizontal = Input.GetAxis( "Horizontal" ); // A/D on keyboard
		float vertical = Input.GetAxis( "Vertical" ); // W/S on keyboard

		// apply our input to our character controller
		cc.Move( new Vector3( horizontal, 0f, vertical ) * 0.5f + Physics.gravity * 0.01f );
	}
}
