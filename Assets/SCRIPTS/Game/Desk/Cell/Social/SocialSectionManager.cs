using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialSectionManager : MonoBehaviour {

    private bool isSocialPanelOpen;
    private bool isSocialOptionsPanelOpen;
    private bool canOpenSocialOptionsPanel;

    private GameObject socialPanel;
    private GameObject socialOptionsPanel;
    private GameObject mySelfPanel;
    private GameObject friendsPanel;
    private GameObject findPanel;
    private GameObject feedPanel;
    private GameObject editPanel;

    GameObject currentSection;
    GameObject previousSection;
    List<GameObject> sectionObjects;
    List<SocialSection> sections;

    private Button socialOptionsBtn;
    private Button socialBackBtn;
    private Button mySelfBtn;
    private Button friendsBtn;
    private Button findBtn;
    private Button feedBtn;
    private Button editBtn;

    private GameObject socialOptionsObj;
    private GameObject socialBackObj;
    private GameObject mySelfObj;
    private GameObject friendsObj;
    private GameObject findObj;
    private GameObject feedObj;
    private GameObject editObj;

    void Awake() {

        socialOptionsPanel = GameObject.FindGameObjectWithTag("SocialOptionsPanel");
        socialPanel = GameObject.FindGameObjectWithTag("SocialPanel");
        mySelfPanel = GameObject.FindGameObjectWithTag("MySelfPanel");
        friendsPanel = GameObject.FindGameObjectWithTag("FriendsPanel");
        findPanel = GameObject.FindGameObjectWithTag("FindFriendsPanel");
        feedPanel = GameObject.FindGameObjectWithTag("FeedPanel");
        editPanel = GameObject.FindGameObjectWithTag("EditPanel");

        isSocialOptionsPanelOpen = false;
        canOpenSocialOptionsPanel = true;
        
        socialOptionsObj = GameObject.FindGameObjectWithTag("SocialOptionsBtn");
        socialBackObj = GameObject.FindGameObjectWithTag("SocialBackBtn");
        mySelfObj = GameObject.FindGameObjectWithTag("MySelfBtn");
        friendsObj = GameObject.FindGameObjectWithTag("FriendsBtn");
        findObj = GameObject.FindGameObjectWithTag("FindFriendsBtn");
        feedObj = GameObject.FindGameObjectWithTag("FeedBtn");
        editObj = GameObject.FindGameObjectWithTag("EditBtn");

        socialOptionsBtn = socialOptionsObj.GetComponent<Button>();
        socialBackBtn = socialBackObj.GetComponent<Button>();
        mySelfBtn = mySelfObj.GetComponent<Button>();
        friendsBtn = friendsObj.GetComponent<Button>();
        findBtn = findObj.GetComponent<Button>();
        feedBtn = feedObj.GetComponent<Button>();
        editBtn = editObj.GetComponent<Button>();

        socialOptionsBtn.onClick.AddListener(() => socialOptionsBtnAction());
        socialBackBtn.onClick.AddListener(() => socialBackBtnAction());
        mySelfBtn.onClick.AddListener(() => mySelfBtnAction());
        friendsBtn.onClick.AddListener(() => friendsBtnAction());
        findBtn.onClick.AddListener(() => findBtnAction());
        feedBtn.onClick.AddListener(() => feedBtnAction());
        editBtn.onClick.AddListener(() => editBtnAction());

        socialOptionsPanel.SetActive(false);
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        editPanel.SetActive(false);
    }

    void socialOptionsBtnAction() {
        Debug.Log("socialOptionsBtn pressed :  ");

        if (canOpenSocialOptionsPanel == true) {
            Debug.Log("SocialOptionPanel -- Opened");
            openSocialOptionsPanel();
        } else {
            Debug.Log("SocialOptionPanel -- Closed");
            closeSocialOptionsPanel();
        }
    }

    void socialBackBtnAction() {
        Debug.Log("socialBackBtn pressed :  ");
        isSocialOptionsPanelOpen = false;
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        feedPanel.SetActive(true);
        editPanel.SetActive(false);
    }

    void mySelfBtnAction() {
        Debug.Log("mySelfBtn pressed :  ");
        isSocialOptionsPanelOpen = false;
        mySelfPanel.SetActive(true);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        feedPanel.SetActive(false);
        editPanel.SetActive(false);
    }

    void friendsBtnAction() {
        Debug.Log("friendsBtn pressed :  ");
        isSocialOptionsPanelOpen = false;
        friendsPanel.SetActive(true);
        mySelfPanel.SetActive(false);
        findPanel.SetActive(false);
        feedPanel.SetActive(false);
        editPanel.SetActive(false);
    }

    void findBtnAction() {
        Debug.Log("findBtn pressed :  ");
        isSocialOptionsPanelOpen = false;
        findPanel.SetActive(true);
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        feedPanel.SetActive(false);
        editPanel.SetActive(false);
    }

    void feedBtnAction() {
        Debug.Log("feedBtn pressed :  ");
        isSocialOptionsPanelOpen = false;
        feedPanel.SetActive(true);
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        editPanel.SetActive(false);
    }

    void editBtnAction() {
        Debug.Log("Button pressed :  ");
        isSocialOptionsPanelOpen = false;
        editPanel.SetActive(true);
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        feedPanel.SetActive(false);
    }

    void closeSocialOptionsPanel() {
        isSocialOptionsPanelOpen = false;
        socialOptionsPanel.SetActive(false);
        canOpenSocialOptionsPanel = true;
        
    }
    void openSocialOptionsPanel() {
        isSocialOptionsPanelOpen = true;
        socialOptionsPanel.SetActive(true);
        canOpenSocialOptionsPanel = false;
    }

    void Update() {
        
        if (isSocialOptionsPanelOpen != true) {
            closeSocialOptionsPanel();
        }
        
    }
}
