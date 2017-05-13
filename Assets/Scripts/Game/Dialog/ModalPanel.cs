using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour {

    public Text dialouge; // this is the display text at any given instance
    public Button BtnA; // these will be dialouge choices for the player. if NPC. else skip and next btns
    public Button BtnB;
    public Button BtnC;

    public Image avatar;// if any this will be for character avatars
    public GameObject modalPanelObject;// the model window panel
    private static ModalPanel modalPanel;

    void Awake() {  
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
    public void Choice(string dialouge, UnityAction choiceAEvent, UnityAction choiceBEvent, UnityAction choiceCEvent) {

        modalPanelObject.SetActive(true);

        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(choiceAEvent);       
        BtnB.onClick.RemoveAllListeners();
        BtnB.onClick.AddListener(choiceBEvent);      
        BtnC.onClick.RemoveAllListeners();
        BtnC.onClick.AddListener(choiceCEvent);      

        this.dialouge.text = dialouge;
        this.avatar.gameObject.SetActive(false);//this is only for main NPCs and other graphics in text
        BtnA.gameObject.SetActive(true);
        BtnB.gameObject.SetActive(true);
        BtnC.gameObject.SetActive(true);

        BtnA.GetComponentInChildren<Text>().text = "LOAD CHOICES FROM DIALOGE TREE HERE";
        BtnB.GetComponentInChildren<Text>().text = "LOAD CHOICES FROM DIALOGE TREE HERE";
        BtnC.GetComponentInChildren<Text>().text = "LOAD CHOICES FROM DIALOGE TREE HERE";
    }

    public void Narrative(UnityAction skipBtnEvent) {
        modalPanelObject.SetActive(true);
        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(skipBtnEvent);        
        BtnA.gameObject.SetActive(true);
        BtnA.GetComponentInChildren<Text>().text = "SKIP";
    }

    public void Question(string dialouge, UnityAction okBtnEvent) {
        modalPanelObject.SetActive(true);

        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(okBtnEvent);
        BtnA.onClick.AddListener(ClosePanel);
        BtnA.GetComponentInChildren<Text>().text = "OK";
        this.dialouge.text = dialouge;
        BtnA.gameObject.SetActive(true);
    }

    void ClosePanel() {
        // Put this in choice,info or question if needed
        // whateverBtn.onClick.AddListener(ClosePanel);
        modalPanelObject.SetActive(false);
    }

    
}
