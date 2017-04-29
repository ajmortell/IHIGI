using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagesSectionManager : MonoBehaviour {

    private GameObject messagesPanel;

    void Awake() {
        messagesPanel = GameObject.FindGameObjectWithTag("MessagesPanel");
    }

    void Update() {

    }

    public void OnClose() {
        print(messagesPanel.tag + " PANEL CLOSED");
        //messagesPanel.SetActive(false);
        //destroy
    }
}
