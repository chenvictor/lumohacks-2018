using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxManager : MonoBehaviour {

    TextAsset textFile;
    string[] textLines;

    GameObject textbox;
    Text textArea;

	// Use this for initialization
	void Start () {
        textbox.SetActive(false);
        if (textFile != null) {
            textLines = textFile.text.Split('\n');
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
