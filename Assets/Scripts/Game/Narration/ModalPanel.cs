using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour {

    public Text dialogueText;

    public Image avatar;
    public Button BtnA;
    public Button BtnB;
    public Button BtnC;
    public Button BtnExit;
    public Button BtnNext;
    private int selected_option = -2;
    public string DialogueDataPath;
    
    public GameObject modalPanelObject;
    private RectTransform panelRect;
    private static ModalPanel modalPanel;// script instance
    private Vector2 panelSize; // current size

    void Awake() {  
        this.panelRect = (RectTransform)modalPanelObject.transform;
        this.panelSize = panelRect.sizeDelta;
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

    // The Narative is for story elements like in teh intro at the bottom screen
    public void Narrative(UnityAction skipBtnEvent) {
        modalPanelObject.SetActive(true);
        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(skipBtnEvent);        
        BtnA.gameObject.SetActive(true);
        BtnA.GetComponentInChildren<Text>().text = "SKIP";
    }

    // This can be used for simple ok responses
    public void Question(string dialogue, UnityAction okBtnEvent) {
        modalPanelObject.SetActive(true);

        BtnA.onClick.RemoveAllListeners();
        BtnA.onClick.AddListener(okBtnEvent);
        BtnA.onClick.AddListener(ClosePanel);
        BtnA.GetComponentInChildren<Text>().text = "OK";
        this.dialogueText.text = dialogue;
        BtnA.gameObject.SetActive(true);
    }

    void ClosePanel() {
        // Put this in choice,info or question if needed
        // whateverBtn.onClick.AddListener(ClosePanel);
        modalPanelObject.SetActive(false);
    }    
}
