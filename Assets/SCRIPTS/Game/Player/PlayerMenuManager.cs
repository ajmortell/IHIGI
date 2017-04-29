using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenuManager : MonoBehaviour {

    public GameObject mainMenuPanel;
    public GameObject skillMenuPanel;

    void Awake() {
        mainMenuPanel.SetActive(true);
        skillMenuPanel.SetActive(false);
    }

    public void OnArrowPress() {
        mainMenuPanel.SetActive(false);
        skillMenuPanel.SetActive(true);
    }

    public void OnBackArrowPress() {
        mainMenuPanel.SetActive(true);
        skillMenuPanel.SetActive(false);
    }

    public void OnSecondArrowPress() {
        skillMenuPanel.SetActive(false);
    }

    public void OnSecondBackArrowPress() {    
        skillMenuPanel.SetActive(true);
    }
}
