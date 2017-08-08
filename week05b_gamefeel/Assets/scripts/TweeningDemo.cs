using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweeningDemo : MonoBehaviour {

	public AnimationCurve tweenCurve; // public so we can edit in Inspector
	public Transform cube;

	void Start () {
		StartCoroutine( MyTweenCoroutine() );
	}
	
	IEnumerator MyTweenCoroutine () {
		float t = 0f; // t will start from 0.0f and gradually go to 1.0f
		Vector3 startPos = transform.position; // remember where we started
		Vector3 endPos = cube.position;
		while (t < 1f) {
			t += Time.deltaTime / 10f; // increment t by deltaTime * 0.1f (will take 10 sec to finish)
			transform.position = Vector3.Lerp( startPos, endPos, tweenCurve.Evaluate( t ) );
			yield return 0; // wait one frame
		}
	}
}
