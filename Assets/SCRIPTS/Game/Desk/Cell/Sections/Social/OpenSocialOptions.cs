using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSocialOptions : MonoBehaviour {

    public GameObject panel;
    private string Name = "SocialOptionsPanel";
    private bool canOpen = true;

    void Awake() {
        panel = GameObject.Find(Name);
        panel.SetActive(false);
    }

    public void OnBtnPress() {

        if (canOpen == true) {
            canOpen = false;
            panel.SetActive(true);
        } else {
            canOpen = true;
            panel.SetActive(false);
        }
    }
}
