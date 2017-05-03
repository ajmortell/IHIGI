using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenuManager : MonoBehaviour {

    public GameObject mainMenuPanel;
    public GameObject skillMenuPanel;
    public GameObject inventoryMenuPanel;

    void Awake() {
        skillMenuPanel.SetActive(false);
        inventoryMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
        
    }

    public void OnArrowPress() {
        mainMenuPanel.SetActive(false);
        skillMenuPanel.SetActive(true);
    }

    public void OnBackArrowPress() {
        skillMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
        
    }

    public void OnSecondArrowPress() {
        skillMenuPanel.SetActive(false);
        inventoryMenuPanel.SetActive(true);
    }

    public void OnSecondBackArrowPress() {
        inventoryMenuPanel.SetActive(false);
        skillMenuPanel.SetActive(true);
    }
}
