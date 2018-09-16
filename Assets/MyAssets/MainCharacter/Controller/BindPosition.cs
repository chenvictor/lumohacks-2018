using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindPosition : MonoBehaviour {

	public GameObject toBind;
	public PlayerController controller;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		controller.bindObject (toBind);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
