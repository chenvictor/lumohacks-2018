using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwitch : MonoBehaviour {

	public AudioSource source;
	public AudioClip switchTo;

	void OnTriggerEnter2D(Collider2D other) {
		switchAudio ();
	}

	void switchAudio() {
		source.Stop();
		source.loop = true;
		source.PlayOneShot (switchTo);
	}
}
