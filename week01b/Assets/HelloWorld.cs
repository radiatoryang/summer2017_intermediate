using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// START = code runs once, right when the object spawns
	void Start () {
		Debug.Log( "Hello World" ); // print "Hello World" to console
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log( "Bonjour Monde" ); // print Bonjour Monde to console
	}
}
