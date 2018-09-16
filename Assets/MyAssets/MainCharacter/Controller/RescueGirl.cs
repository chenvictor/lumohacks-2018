using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueGirl : MonoBehaviour {
    public GameObject drowning;
    public GameObject notDrowning;

    public TextAsset textFile;
    public TextboxManager manager;

    // Use this for initialization
    void Start () {
        notDrowning.SetActive(false);
	}

    void OnTriggerEnter2D()
    {
        manager.RunFile(textFile);
        notDrowning.SetActive(true);
        drowning.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
