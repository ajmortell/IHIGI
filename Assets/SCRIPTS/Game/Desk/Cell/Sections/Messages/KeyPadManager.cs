using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadManager : MonoBehaviour {

    public GameObject keyPadPanel;
    public GameObject closeKeyPadPanel;

    private bool canClose;

    void Awake () {
        canClose = true;
        closeKeyPadPanel.SetActive(false);
    }

    public void onCloseKeyPad() {
        if (canClose == true) {
            canClose = false;
            closeKeyPadPanel.SetActive(true);
            keyPadPanel.SetActive(false);
        } else {
            canClose = true;
            closeKeyPadPanel.SetActive(false);
            keyPadPanel.SetActive(true);
        }
    }

	void Update () {
		
	}
}
