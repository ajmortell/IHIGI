using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OpenSection : MonoBehaviour {

    public GameObject messagesPanel;
    public GameObject calendarPanel;
    public GameObject socialPanel;
    public GameObject contactsPanel;
    public GameObject phonePanel;
    public GameObject mailPanel;
    public GameObject browserPanel;
    public GameObject musicPanel;
    
    
    void Awake() {
        messagesPanel.SetActive(false);
        calendarPanel.SetActive(false);
        socialPanel.SetActive(false);
        contactsPanel.SetActive(false);
        phonePanel.SetActive(false);
        mailPanel.SetActive(false);
        browserPanel.SetActive(false);
        musicPanel.SetActive(false);      
    }

    public void OnBtnPress(Button btn) {

        switch (btn.tag) {

            case "MessagesSectionBtn":
                print("MESSAGES CASE");
                messagesPanel.SetActive(true);       
                break;

            case "CalendarSectionBtn":
                print("CALENDAR CASE");
                calendarPanel.SetActive(true);
                break;

            case "SocialSectionBtn":
                print("SOCIAL CASE");
                socialPanel.SetActive(true);
                break;

            case "ContactsSectionBtn":
                print("CONTACTS CASE");
                contactsPanel.SetActive(true);
                break;

            case "PhoneSectionBtn":
                print("PHONE CASE");
                phonePanel.SetActive(true);
                break;

            case "MailSectionBtn":
                print("MAIL CASE");
                mailPanel.SetActive(true);
                break;

            case "BrowserSectionBtn":
                print("BROWSER CASE");
                browserPanel.SetActive(true);
                break;

            case "MusicSectionBtn":
                print("MUSIC CASE");
                musicPanel.SetActive(true);
                break;      
        }    
    }

    public void OnBackBtnPress(Button btn) {

        switch (btn.tag) {

            case "MessagesBackBtn":
                print("MESSAGES Back CASE");
                messagesPanel.SetActive(false);

                break;

            case "CalendarBackBtn":
                print("CALENDAR Back CASE");
                calendarPanel.SetActive(false);
                break;

            case "SocialBackBtn":
                print("SOCIAL Back CASE");
                socialPanel.SetActive(false);
                break;

            case "ContactsBackBtn":
                print("CONTACTS Back CASE");
                contactsPanel.SetActive(false);
                break;

            case "PhoneBackBtn":
                print("PHONE Back CASE");
                phonePanel.SetActive(false);
                break;

            case "MailBackBtn":
                print("MAIL Back CASE");
                mailPanel.SetActive(false);
                break;

            case "BrowserBackBtn":
                print("BROWSER Back CASE");
                browserPanel.SetActive(false);
                break;

            case "MusicBackBtn":
                print("MUSIC Back CASE");
                musicPanel.SetActive(false);
                break;
        }
    }
}
