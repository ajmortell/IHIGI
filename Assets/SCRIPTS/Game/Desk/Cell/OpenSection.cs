using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSection : MonoBehaviour {

    private GameObject panel = null;
    private SocialSection section;

    private string Name;
    private bool isOpen = false;
    private bool canOpen = true;

    void Awake() {
        panel = GameObject.Find(Name);
        panel.SetActive(false);
    }

    public void OnBtnPress(GameObject btn) {
        if (canOpen == true) {
            Debug.Log(Name + " Opened");
            isOpen = true;
            canOpen = false;
            panel.SetActive(true);
        } else {
            Debug.Log(Name + " Closed");
            isOpen = false;
            canOpen = true;
            panel.SetActive(false);
        }
    }
}
