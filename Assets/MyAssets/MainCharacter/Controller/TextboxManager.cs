 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxManager : MonoBehaviour {

	public PlayerController controller;
    public TextAsset textFile;
    public string[] textLines;

    public GameObject textbox;
    public Text textArea;
    public int curIdx;
    private int endIdx;

	// Use this for initialization
	void Start () {
        if (textFile != null) {
            textLines = textFile.text.Split('\n');
        }
        curIdx = -1;
        endIdx = textLines.Length;
	}

	public void RunFile(TextAsset file) {
		textFile = file;
		Start ();
		curIdx = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (curIdx >= 0 && curIdx < endIdx)
        {
			if (controller != null) {
				controller.setEnabled (false);
			}
            textbox.SetActive(true);
            textArea.text = textLines[curIdx];
        }
        else {
			if (controller != null) {
				controller.setEnabled (true);
			}
            textbox.SetActive(false);
        }
  
        if (Input.GetKeyDown(KeyCode.Return)) {
            curIdx += 1;
        }
       
	}
}
