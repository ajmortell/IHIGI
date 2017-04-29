using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadManager : MonoBehaviour {

    public GameObject keyPadPanel;
    public GameObject closeKeyPadPanel;

    private bool isOpen;
    private bool canClose;

    void Awake () {
        isOpen = true;
        canClose = true;
        closeKeyPadPanel.SetActive(false);
    }

    public void onCloseKeyPad() {
        if (canClose == true) {
            isOpen = false;
            canClose = false;
            closeKeyPadPanel.SetActive(true);
            keyPadPanel.SetActive(false);
        } else {
            isOpen = true;
            canClose = true;
            closeKeyPadPanel.SetActive(false);
            keyPadPanel.SetActive(true);
        }
    }

	void Update () {
		
	}
}
