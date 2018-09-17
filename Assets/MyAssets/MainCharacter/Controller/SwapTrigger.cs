using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTrigger : MonoBehaviour {
    public GameObject toHide;
    public GameObject toShow;

    // Use this for initialization
    void Start () {
        toShow.SetActive(false);
	}

    void OnTriggerEnter2D()
    {
        toShow.SetActive(true);
        toHide.SetActive(false);
    }
}
