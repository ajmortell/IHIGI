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
    private GameObject postWindowPanel;

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
    private Button exitBtn;
    private Button postBtn;
    private Button discardBtn;
    private Button doneBtn;

    private GameObject socialOptionsObj;
    private GameObject socialBackObj;
    private GameObject mySelfObj;
    private GameObject friendsObj;
    private GameObject findObj;
    private GameObject feedObj;
    private GameObject editObj;
    private GameObject exitObj;
    private GameObject postObj;
    private GameObject discardObj;
    private GameObject doneObj;

    void Awake() {

        socialOptionsPanel = GameObject.FindGameObjectWithTag("SocialOptionsPanel");
        socialPanel = GameObject.FindGameObjectWithTag("SocialPanel");
        mySelfPanel = GameObject.FindGameObjectWithTag("MySelfPanel");
        friendsPanel = GameObject.FindGameObjectWithTag("FriendsPanel");
        findPanel = GameObject.FindGameObjectWithTag("FindFriendsPanel");
        feedPanel = GameObject.FindGameObjectWithTag("FeedPanel");
        editPanel = GameObject.FindGameObjectWithTag("EditPanel");
        postWindowPanel = GameObject.FindGameObjectWithTag("PostWindowPanel");

        isSocialOptionsPanelOpen = false;
        canOpenSocialOptionsPanel = true;
        
        socialOptionsObj = GameObject.FindGameObjectWithTag("SocialOptionsBtn");
        socialBackObj = GameObject.FindGameObjectWithTag("SocialBackBtn");
        mySelfObj = GameObject.FindGameObjectWithTag("MySelfBtn");
        friendsObj = GameObject.FindGameObjectWithTag("FriendsBtn");
        findObj = GameObject.FindGameObjectWithTag("FindFriendsBtn");
        feedObj = GameObject.FindGameObjectWithTag("FeedBtn");
        editObj = GameObject.FindGameObjectWithTag("EditBtn");
        exitObj = GameObject.FindGameObjectWithTag("ExitEditBtn");
        postObj = GameObject.FindGameObjectWithTag("PostBtn");
        discardObj = GameObject.FindGameObjectWithTag("DiscardBtn");
        doneObj = GameObject.FindGameObjectWithTag("DoneBtn");

        socialOptionsBtn = socialOptionsObj.GetComponent<Button>();
        socialBackBtn = socialBackObj.GetComponent<Button>();
        mySelfBtn = mySelfObj.GetComponent<Button>();
        friendsBtn = friendsObj.GetComponent<Button>();
        findBtn = findObj.GetComponent<Button>();
        feedBtn = feedObj.GetComponent<Button>();
        editBtn = editObj.GetComponent<Button>();
        exitBtn = exitObj.GetComponent<Button>();
        postBtn = postObj.GetComponent<Button>();
        discardBtn = discardObj.GetComponent<Button>();
        doneBtn = doneObj.GetComponent<Button>();


        socialOptionsBtn.onClick.AddListener(() => socialOptionsBtnAction());
        socialBackBtn.onClick.AddListener(() => socialBackBtnAction());
        mySelfBtn.onClick.AddListener(() => mySelfBtnAction());
        friendsBtn.onClick.AddListener(() => friendsBtnAction());
        findBtn.onClick.AddListener(() => findBtnAction());
        feedBtn.onClick.AddListener(() => feedBtnAction());
        editBtn.onClick.AddListener(() => editBtnAction());
        exitBtn.onClick.AddListener(() => exitBtnAction());
        postBtn.onClick.AddListener(() => postBtnAction());
        discardBtn.onClick.AddListener(() => discardBtnAction());
        doneBtn.onClick.AddListener(() => doneBtnAction());

        socialOptionsPanel.SetActive(false);
        mySelfPanel.SetActive(false);
        friendsPanel.SetActive(false);
        findPanel.SetActive(false);
        editPanel.SetActive(false);
        postWindowPanel.SetActive(false);
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
        postWindowPanel.SetActive(false);
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

    void postBtnAction() {
        Debug.Log("postBtn pressed :  ");
        postWindowPanel.SetActive(true);
    }

    void doneBtnAction() {
        Debug.Log("doneBtn pressed :  ");
        postWindowPanel.SetActive(false);
    }

    void discardBtnAction() {
        Debug.Log("discardBtn pressed :  ");
        postWindowPanel.SetActive(false);
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

    void exitBtnAction()
    {
        Debug.Log("Button pressed :  ");
        isSocialOptionsPanelOpen = false;
        editPanel.SetActive(false);
        mySelfPanel.SetActive(true);
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
