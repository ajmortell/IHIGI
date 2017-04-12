using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Letter : MonoBehaviour {

    private Text letterText;
    private GameObject letterObject;
    private string letter;

	void Start () {
        letterObject = gameObject;
        letterText = letterObject.GetComponent<Text>();
        letter = letterText.text;
    }
	
    public string returnLetter() {
        return letter;
    }
}
