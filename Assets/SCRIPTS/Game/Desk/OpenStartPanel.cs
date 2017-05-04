using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStartPanel : MonoBehaviour {

    public GameObject panel = null;
    private string Name = "StartMenuPanel";
    private bool canOpen = true;

    void Awake() {
        panel = GameObject.Find(Name);
        panel.SetActive(false);
    }

    public void OnBtnPress() {
        if (canOpen == true) {
            Debug.Log(Name + " Opened");
            canOpen = false;
            panel.SetActive(true);
        } else {
            canOpen = true;
            panel.SetActive(false);
        }

    }
}
