using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BackButtonManager : MonoBehaviour {

    private GameObject panel;

    void Awake() {
        panel = null;
    }

    public void OnBackBtnPress(Button btn) {

        switch (btn.tag) {

            case "MessagesBackBtn":
                print("MESSAGES BACK CASE");
                panel = GameObject.FindGameObjectWithTag("MessagesPanel");
                break;

            case "ContactsBackBtn":
                panel = GameObject.FindGameObjectWithTag("ContactsPanel");
                break;

            case "CalendarBackBtn":
                panel = GameObject.FindGameObjectWithTag("CalendarPanel");
                break;

            case "EmailBackBtn":
                panel = GameObject.FindGameObjectWithTag("EmailPanel");
                break;

            case "MusicBackBtn":
                panel = GameObject.FindGameObjectWithTag("MusicPanel");
                break;

            case "BrowserBackBtn":
                panel = GameObject.FindGameObjectWithTag("BrowserPanel");
                break;

            case "SocialBackBtn":
                panel = GameObject.FindGameObjectWithTag("SocialPanel");
                break;

            case "PhoneBackBtn":
                panel = GameObject.FindGameObjectWithTag("PhonePanel");
                break;

        }
        panel.SetActive(false);
        //panel = null;
    }

}
