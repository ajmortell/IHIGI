using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectAllBtn : MonoBehaviour {

    public Toggle selectAllToggle = null;

    //public GameObject checkboxTEST = null;

    private bool isSelected = false;
    private bool canSelect = true;

    private void Awake() {
        selectAllToggle = gameObject.GetComponent<Toggle>();
    }

    public bool returnSelected()
    {
        return selectAllToggle.isOn;
    }

    public void checkSelected(bool value)
    {
        selectAllToggle.isOn = value;
    }

    public void OnSelect()
    {
        if (canSelect == true)
        {
            isSelected = true;
            canSelect = false;
            checkSelected(isSelected);
            print("--SELECT ALL BTN _ SELECTED:  " + isSelected);
        }
        else
        {
            isSelected = false;
            canSelect = true;
            checkSelected(isSelected);
            print("--SELECT ALL BTN _ SELECTED:  " + isSelected);

        }

    }
}
