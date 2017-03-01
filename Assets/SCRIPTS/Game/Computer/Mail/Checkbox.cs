using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Checkbox : MonoBehaviour {

    public Toggle checkbox = null;
    private bool isSelected = false;
    private bool canSelect = true;

    private void Awake() {
        checkbox = GetComponent<Toggle>();
    }

    public bool returnSelected() {
        return checkbox.isOn;
    }

    public void checkSelected(bool value) {
        checkbox.isOn = value;
    }

    public void OnSelect() {
        if (canSelect == true)
        {
            isSelected = true;
            canSelect = false;
            checkSelected(isSelected);
            print("--CHECK BOX _ SELECTED:  " + isSelected);
        }
        else
        {
            isSelected = false;
            canSelect = true;
            checkSelected(isSelected);
            print("--CHECK BOX _ SELECTED:  " + isSelected);

        }
        
    }
}
