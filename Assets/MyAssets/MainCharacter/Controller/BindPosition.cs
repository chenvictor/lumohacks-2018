using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindPosition : MonoBehaviour {

	public GameObject toBind;
	public PlayerController controller;

	void OnTriggerEnter2D(Collider2D other) {
		controller.bindObject (toBind);
	}
}
