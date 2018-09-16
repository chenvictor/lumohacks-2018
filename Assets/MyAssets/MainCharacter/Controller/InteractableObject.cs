using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

	public TextAsset textFile;
	public TextboxManager manager;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		manager.RunFile (textFile);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
