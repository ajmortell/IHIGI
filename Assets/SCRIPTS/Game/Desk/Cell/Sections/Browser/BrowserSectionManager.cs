using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrowserSectionManager : MonoBehaviour {

    private GameObject panel;

    void Awake() {
       // panel = GameObject.FindGameObjectWithTag("BrowserPanel");
    }

    void Update() {
    }

    public void OnClose() {
       // panel.SetActive(false);
    }
}
