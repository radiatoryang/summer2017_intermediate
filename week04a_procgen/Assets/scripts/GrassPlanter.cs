using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; // you need this to change scenes

public class GrassPlanter : MonoBehaviour {

	public GameObject grassPrefab; // fill-in in Inspector

	void Start () {
		// if the seed is always the same number, you'll always get the same randomness, for example:
		// Random.seed = 420;

		int grassCounter = 0; // keep track of how many grass clones I made

		while (grassCounter < 2000) { // as long as grassCounter is less than 2000, keep making grass
			Instantiate( 
				grassPrefab, 
				new Vector3(Random.Range( -10f, 10f ), 0f, Random.Range( -10f, 10f )),
				Quaternion.Euler( 0f, Random.Range( 0f, 360f ), 0f )
			);
			grassCounter += 1; // increment counter variable
		}

	}

	void Update () {
		// press R to reload the current scene and get a new grass planting
		if (Input.GetKeyDown( KeyCode.R )) {
			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
		}
	}
}
