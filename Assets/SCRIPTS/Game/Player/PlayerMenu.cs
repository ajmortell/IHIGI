using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu : MonoBehaviour {

    public GameObject menuCanvas;
   
    private bool isOpen = false;
    public bool canOpen = true;

    void Awake () {
        menuCanvas.SetActive(false);
      
    }

    void Update () {

        if (Input.GetKeyDown("m")) {
            if (canOpen == true) {
                isOpen = true;
                canOpen = false;
                print("OPEN");
                menuCanvas.SetActive(isOpen);
                
            } else {
                isOpen = false;
                canOpen = true;
                print("CLOSE");
                menuCanvas.SetActive(isOpen);
             
            }
        }
    }
}
