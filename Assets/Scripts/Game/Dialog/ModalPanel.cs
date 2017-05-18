using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour {

    public Text dialougeText; // this is the display text at any given instance
    public Button BtnA; // these should able to be used for any button needed
    public Button BtnB;
    public Button BtnC;
    public Button BtnExit; // exits the window if needed
    public Button BtnNext; // next set of dialouge if needed

    public Image avatar;// if any this will be for main npc character dialouge imgs
    public GameObject modalPanelObject;// the model window panel
    private static ModalPanel modalPanel;// this script instance

    private RectTransform panelRect; // this should be used to get and set the pos of a given panel
    private Vector2 panelSize; // the current size then resize if needed

    void Awake() {  
        this.panelRect = (RectTransform)modalPanelObject.transform;
        this.panelSize = panelRect.sizeDelta;
        print("PANEL SIZE: "+panelSize);
    }

    public RectTransform getPanelTransform() {
        return panelRect;
    }

    public Vector2 getPanelSize() {
        return panelSize;
    }

    public static ModalPanel Instance () {
        if(!modalPanel) {
            modalPanel = FindObjectOfType(typeof(ModalPanel)) as ModalPanel;
            if (!modalPanel) {
                Debug.LogError("There can be only one!");
            }
        }
        return modalPanel;
    }

    
    // choice a / choice b / choice c: A string and 3 event choices for the player to make.
    public void NPCDialouge(string dialouge, Image img, UnityAction choiceAEvent, bool isA_Active, UnityAction choiceBEvent, bool isB_Active, UnityAction choiceCEvent, bool isC_Active) {

        modalPanelObject.SetActive(true);

        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(choiceAEvent);       
        BtnB.onClick.RemoveAllListeners();
        BtnB.onClick.AddListener(choiceBEvent);      
        BtnC.onClick.RemoveAllListeners();
        BtnC.onClick.AddListener(choiceCEvent);

        BtnExit.onClick.RemoveAllListeners();
        BtnExit.onClick.AddListener(ClosePanel);
        BtnNext.onClick.RemoveAllListeners();
        BtnNext.onClick.AddListener(choiceCEvent);

        this.dialougeText.text = dialouge;
        if (img = null) {
            this.avatar.gameObject.SetActive(false);
        } else {
            this.avatar.gameObject.SetActive(true);
        }

        BtnA.gameObject.SetActive(isA_Active);
        BtnB.gameObject.SetActive(isB_Active);
        BtnC.gameObject.SetActive(isC_Active);

        BtnA.GetComponentInChildren<Text>().text = "LOAD CHOICES FROM DIALOGE TREE HERE";
        BtnB.GetComponentInChildren<Text>().text = "LOAD CHOICES FROM DIALOGE TREE HERE";
        BtnC.GetComponentInChildren<Text>().text = "LOAD CHOICES FROM DIALOGE TREE HERE";
    }

    // The Narative is for story elements like in teh intro at the bottom screen
    public void Narrative(UnityAction skipBtnEvent) {
        modalPanelObject.SetActive(true);
        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(skipBtnEvent);        
        BtnA.gameObject.SetActive(true);
        BtnA.GetComponentInChildren<Text>().text = "SKIP";
    }

    // This can be used for simple ok responses
    public void Question(string dialouge, UnityAction okBtnEvent) {
        modalPanelObject.SetActive(true);

        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(okBtnEvent);
        BtnA.onClick.AddListener(ClosePanel);
        BtnA.GetComponentInChildren<Text>().text = "OK";
        this.dialougeText.text = dialouge;
        BtnA.gameObject.SetActive(true);
    }

    void ClosePanel() {
        // Put this in choice,info or question if needed
        // whateverBtn.onClick.AddListener(ClosePanel);
        modalPanelObject.SetActive(false);
    }

    
}
