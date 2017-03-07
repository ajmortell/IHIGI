using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectAll : MonoBehaviour {
    private bool isSelected = false;
    private bool canSelect = true;
    public Toggle checkbox = null;
    public GameObject[] checkBoxGroup;

    public void iterateBoxes(bool value) {
        checkBoxGroup = GameObject.FindGameObjectsWithTag("CheckBox");
        foreach (GameObject checkBox in checkBoxGroup) {
            checkbox = checkBox.GetComponent<Toggle>();
            checkbox.isOn = value;
        }
    }

    public void OnSelect() {
        if (canSelect == true) {
            isSelected = true;
            canSelect = false;
            print("--SELECTED:  " + isSelected);
            iterateBoxes(isSelected);
        } else {         
            isSelected = false;
            canSelect = true;
            print("--SELECTTED:  " + isSelected);
            iterateBoxes(isSelected);
        }
    }
}