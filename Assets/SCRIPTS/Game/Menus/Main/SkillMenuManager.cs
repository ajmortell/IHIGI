using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class SkillMenuManager : MonoBehaviour {

    private List<SkillItem> skillItems;
    private List<GameObject> newItems;

    private GameObject skillListPanel;
    public GameObject ContentPanel;
    public GameObject skillSetItemPrefab;

    private GameObject SkillButtons;

    private GameObject skillBtnObjA;
    private GameObject skillBtnObjB;
    private GameObject skillBtnObjC;
    private GameObject skillBtnObjD;
    private GameObject skillBtnObjE;

    private Button skillBtnA;
    private Button skillBtnB;
    private Button skillBtnC;
    private Button skillBtnD;
    private Button skillBtnE;

    private GameObject skillPanelObjA;
    private GameObject skillPanelObjB;
    private GameObject skillPanelObjC;
    private GameObject skillPanelObjD;
    private GameObject skillPanelObjE;

    private GameObject skillTypeBtnPanel;

    private GameObject mindBtnObj;
    private GameObject strengthBtnObj;
    private GameObject courageBtnObj;
    private GameObject charmBtnObj;

    private Button mindBtn;
    private Button strengthBtn;
    private Button courageBtn;
    private Button charmBtn;

    void Awake() {

        skillItems = new List<SkillItem>();
        newItems = new List<GameObject>();

        skillListPanel = GameObject.FindGameObjectWithTag("SkillListPanel");
        SkillButtons = GameObject.FindGameObjectWithTag("SkillButtons");
        skillTypeBtnPanel = GameObject.FindGameObjectWithTag("SkillTypeBtnPanel");

        skillListPanel.SetActive(false);
        SkillButtons.SetActive(true);  
        skillTypeBtnPanel.SetActive(false);

        skillBtnObjA = GameObject.FindGameObjectWithTag("SkillBtnA");
        skillBtnObjB = GameObject.FindGameObjectWithTag("SkillBtnB");
        skillBtnObjC = GameObject.FindGameObjectWithTag("SkillBtnC");
        skillBtnObjD = GameObject.FindGameObjectWithTag("SkillBtnD");
        skillBtnObjE = GameObject.FindGameObjectWithTag("SkillBtnE");

        skillBtnA = skillBtnObjA.GetComponent<Button>();
        skillBtnB = skillBtnObjB.GetComponent<Button>();
        skillBtnC = skillBtnObjC.GetComponent<Button>();
        skillBtnD = skillBtnObjD.GetComponent<Button>();
        skillBtnE = skillBtnObjE.GetComponent<Button>();

        skillBtnA.onClick.AddListener(() => skillBtnAction(skillBtnA.tag));
        skillBtnB.onClick.AddListener(() => skillBtnAction(skillBtnB.tag));
        skillBtnC.onClick.AddListener(() => skillBtnAction(skillBtnC.tag));
        skillBtnD.onClick.AddListener(() => skillBtnAction(skillBtnD.tag));
        skillBtnE.onClick.AddListener(() => skillBtnAction(skillBtnE.tag));

        setupSkillBtnPanels();
    }

    public void setupSkillBtnPanels() {
        skillPanelObjA = GameObject.FindGameObjectWithTag("SkillPanelA");
        skillPanelObjB = GameObject.FindGameObjectWithTag("SkillPanelB");
        skillPanelObjC = GameObject.FindGameObjectWithTag("SkillPanelC");
        skillPanelObjD = GameObject.FindGameObjectWithTag("SkillPanelD");
        skillPanelObjE = GameObject.FindGameObjectWithTag("SkillPanelE");

        skillPanelObjA.SetActive(false);
        skillPanelObjB.SetActive(false);
        skillPanelObjC.SetActive(false);
        skillPanelObjD.SetActive(false);
        skillPanelObjE.SetActive(false);
    }

    public void cleanUp() {
        foreach (SkillItem oldItem in skillItems) {
            skillItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            DestroyImmediate(fabObjects);
        }
    }

    public void populateSkillSetList(string tag) {
        skillItems = new List<SkillItem>();
        cleanUp();

        switch (tag) {
            case "MindBtn":
                print("MIND SKILLS POPULATED");
                skillItems.Add(new SkillItem("Night Owel"));
                skillItems.Add(new SkillItem("Straight Shooter"));
                skillItems.Add(new SkillItem("Super Scientist"));
                skillItems.Add(new SkillItem("Developing Mind"));
                skillItems.Add(new SkillItem("Professional Autuer"));
                skillItems.Add(new SkillItem("Energetic Engineer"));
                break;

            case "CharmBtn":
                print("CHARM SKILLS POPULATED");
                skillItems.Add(new SkillItem("Charming Charmer"));
                skillItems.Add(new SkillItem("Artful Nature"));
                break;

            case "CourageBtn":
                print("CHARM SKILLS POPULATED");
                skillItems.Add(new SkillItem("Double Integrity"));
                skillItems.Add(new SkillItem("Wild Card"));
                skillItems.Add(new SkillItem("Chance Encounter"));
                skillItems.Add(new SkillItem("Arrogant Consistency"));
                skillItems.Add(new SkillItem("Prophetic Dreamer"));
                break;

            case "StrengthBtn":
                print("STRENGTH SKILLS POPULATED");
                skillItems.Add(new SkillItem("Punctual Person"));
                break;
        }

        foreach (SkillItem item in skillItems) {
            GameObject newItem = Instantiate(skillSetItemPrefab) as GameObject;
            SkillItemController controller = newItem.GetComponent<SkillItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
            newItems.Add(newItem);
        }
    }

    public void skillBtnAction (string tag) {
        
       skillTypeBtnPanel.SetActive(true);
        SkillButtons.SetActive(false);
    }

    public void OnCloseSkillTypes() {
        SkillButtons.SetActive(true);
        skillTypeBtnPanel.SetActive(false);
    }

    public void OnCloseSkillList() {
        skillTypeBtnPanel.SetActive(true);
        skillListPanel.SetActive(false);
    }

    public void OnBtnPress(Button btn) {

        switch (btn.tag) {
            case "MindBtn":
                print("MIND BTN PRESSED");
                skillTypeBtnPanel.SetActive(false);
                skillListPanel.SetActive(true);
                populateSkillSetList(btn.tag);
                break;

            case "CharmBtn":
                print("CHARM BTN PRESSED");
                skillTypeBtnPanel.SetActive(false);
                skillListPanel.SetActive(true);
                populateSkillSetList(btn.tag);
                break;

            case "CourageBtn":
                print("COURAGE BTN PRESSED");
                skillTypeBtnPanel.SetActive(false);
                skillListPanel.SetActive(true);
                populateSkillSetList(btn.tag);
                break;

            case "StrengthBtn":
                print("STRENGTH BTN PRESSED");
                skillTypeBtnPanel.SetActive(false);
                skillListPanel.SetActive(true);
                populateSkillSetList(btn.tag);
                break;
        }
    }
}
