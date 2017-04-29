using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarSectionManager : MonoBehaviour {

    private GameObject calendarPanel;

    void Awake() {
        calendarPanel = GameObject.FindGameObjectWithTag("CalendarPanel");
    }

    void Update() {

    }

    public void OnClose() {
        print(calendarPanel.tag + " PANEL CLOSED");
        //calendarPanel.SetActive(false);
        //destroy
    }
}