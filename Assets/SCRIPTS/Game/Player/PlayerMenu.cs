using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerMenu : MonoBehaviour {

    private bool canOpen = true;
    private int previousSceneID;
    private int menuID;

    void Awake () {
        menuID = 9;
        previousSceneID = SceneManager.GetActiveScene().buildIndex;
    }

    void Update () {
        if(SceneManager.GetActiveScene().buildIndex != menuID) {
            if (SceneManager.GetActiveScene().buildIndex != previousSceneID) {
                previousSceneID = SceneManager.GetActiveScene().buildIndex;
            }
        }

        if (Input.GetKeyDown("m")) {
            if (canOpen == true) {
                canOpen = false;
                SceneManager.LoadScene(menuID);
            } else {
                canOpen = true;
                SceneManager.LoadScene(previousSceneID);
                
            }
        }
    }
}
