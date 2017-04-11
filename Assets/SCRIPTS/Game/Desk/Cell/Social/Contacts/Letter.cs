using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Letter : MonoBehaviour {

    private Text letterText;
    private GameObject letterObject;
    private string letter;
	// Use this for initialization
	void Start () {

        letterObject = gameObject;
        letterText = letterObject.GetComponent<Text>();
        letter = letterText.text;
        print("LETTER IS: " + letter);
    }
	
    public string returnLetter() {
        return letter;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
