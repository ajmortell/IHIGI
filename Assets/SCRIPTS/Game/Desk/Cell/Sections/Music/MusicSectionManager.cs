using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSectionManager : MonoBehaviour
{
    private GameObject panel;

    void Awake() {
        panel = GameObject.FindGameObjectWithTag("MusicPanel");
    }

    void Update() {

    }

    public void OnClose() {
        //panel.SetActive(false);
        //destroy
    }
}