using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayDemo : MonoBehaviour {

	// "SerializeField" exposes a field to inspector without making it public
	[SerializeField] AudioSource myAudio;

	void Update () {
		// if I press spacebar, then play the sound
		if (Input.GetKeyDown( KeyCode.Space )) {
			// scenario 1: standard sound playback
			// weakness: this will interrupt itself if it's already playing
			// myAudio.Play(); // simplest way to start playing your sound

			// scenario 2: fast frequent sounds
			// playOneShot = automatically clone another AudioSource to play this sound
			// and it will self-destruct when the sound is over; cannot be interrupted
			// myAudio.PlayOneShot( myAudio.clip );

			// scenario 3: what if you want to play a sound, but only if it's not already playing?
//			if (myAudio.isPlaying == false) {
//				myAudio.Play();
//			}

			// scenario 4: toggle a looping sound on or off?
			if (myAudio.isPlaying) {
				// sound is already playing, so let's turn off the sound
				myAudio.Stop();
			} else {
				// sound is NOT already playing, toggle ON the sound
				myAudio.loop = true;
				myAudio.Play();
			}
		}
	}
}
