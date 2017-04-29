using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OpenSocialSection : MonoBehaviour {

    public GameObject mySelfPanel;
    public GameObject friendsPanel;
    public GameObject findPanel;
    public GameObject feedPanel;
    public GameObject editPanel;
    public GameObject postPanel;

    void Awake()
    {
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        feedPanel.SetActive(false);
        editPanel.SetActive(false);
        postPanel.SetActive(false);

    }

    public void OnBtnPress(Button btn)
    {

        switch (btn.tag) {

            case "MySelfPanel":
                print("MYSELF CASE");
                mySelfPanel.SetActive(true);
                break;

            case "FriendsPanel":
                print("FRIENDS CASE");
                friendsPanel.SetActive(true);
                break;

            case "FindPanel":
                print("FIND CASE");
                findPanel.SetActive(true);
                break;

            case "FeedPanel":
                print("FEED CASE");
                feedPanel.SetActive(true);
                break;

            case "EditPanel":
                print("EIDT CASE");
                editPanel.SetActive(true);
                break;

            case "PostPanel":
                print("POST CASE");
                postPanel.SetActive(true);
                break;
        }
    }

    public void OnBackBtnPress(Button btn) {

        switch (btn.tag) {

            case "MySelfPanel":
                print("MYSELF CASE");
                mySelfPanel.SetActive(true);
                break;

            case "FriendsPanel":
                print("FRIENDS CASE");
                friendsPanel.SetActive(true);
                break;

            case "FindPanel":
                print("FIND CASE");
                findPanel.SetActive(true);
                break;

            case "FeedPanel":
                print("FEED CASE");
                feedPanel.SetActive(true);
                break;

            case "EditPanel":
                print("EIDT CASE");
                editPanel.SetActive(true);
                break;

            case "PostPanel":
                print("POST CASE");
                postPanel.SetActive(true);
                break;
        }
    }
}
