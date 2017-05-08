using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    private void Awake() {
       
    }

    public void Quit() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }

    private void Update() {
        if (Input.GetKeyDown("q")) {
            print("QUITING.......");
            Quit();
        }
    }
}
