using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGod : MonoBehaviour {

	// when you instantiate, you don't always have to use GameObject, you can use
	// any component on the original prefab as a reference, and it'll clone THE WHOLE OBJECT
	public Fish fishPrefab;

	void Update () {
		// if I press F, then spawn a new fish
		if (Input.GetKeyDown( KeyCode.F )) {
			
			// spawn a new fish
			Fish newFishClone = Instantiate( fishPrefab, Vector3.zero, Quaternion.Euler(0f, 0f, 0f) );

			// because we store newFishClone in a var, we can do more stuff with it...
			newFishClone.moveSpeed = Random.Range( 1f, 10f );
			newFishClone.transform.localScale *= Random.Range( 0.1f, 10f );

			// if you wanted the new fish to the FishGod, here's how
			// newFishClone.transform.SetParent( transform );
		}
	}
}
