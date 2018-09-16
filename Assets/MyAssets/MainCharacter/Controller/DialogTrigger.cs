using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour {

	public TextAsset textFile;
	public TextboxManager manager;

	void OnTriggerEnter2D(Collider2D other) {
        manager.RunFile(textFile);
	}
}
