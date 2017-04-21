using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class SkillMenuBtnsManager : MonoBehaviour {

    private List<GameObject> skillBtnPanelItems;
    private List<SkillSetItem> skillSetItems;//
    private List<GameObject> newItems;//

    private GameObject skillSetListPanel;//
    public GameObject ContentPanel;//
    public GameObject skillSetItemPrefab;//
    
    private GameObject skillBtnObjA;//
    private GameObject skillBtnObjB;//
    private GameObject skillBtnObjC;//
    private GameObject skillBtnObjD;//
    private GameObject skillBtnObjE;//

    private Button skillBtnA;//
    private Button skillBtnB;//
    private Button skillBtnC;//
    private Button skillBtnD;//
    private Button skillBtnE;//

    private GameObject skillPanelObjA;
    private GameObject skillPanelObjB;
    private GameObject skillPanelObjC;
    private GameObject skillPanelObjD;
    private GameObject skillPanelObjE;

    void Awake() {
        skillBtnPanelItems = new List<GameObject>();

        skillSetItems = new List<SkillSetItem>();
        newItems = new List<GameObject>();
        skillSetListPanel = GameObject.FindGameObjectWithTag("SkillSetListPanel");
        //setupSkillBtnPanels();
        skillSetListPanel.SetActive(false);

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
        foreach (SkillSetItem oldItem in skillSetItems) {
            skillSetItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            DestroyImmediate(fabObjects);
        }
    }

    public void populateSkillSetList() {
        skillSetItems = new List<SkillSetItem>();
        cleanUp();

        skillSetItems.Add(new SkillSetItem("Charming Charmer", false));
        skillSetItems.Add(new SkillSetItem("Double Integrity", false));
        skillSetItems.Add(new SkillSetItem("Night Owel", false));
        skillSetItems.Add(new SkillSetItem("Straight Shooter", false));
        skillSetItems.Add(new SkillSetItem("Punctual Person", false));
        skillSetItems.Add(new SkillSetItem("Wild Card ", false));
        skillSetItems.Add(new SkillSetItem("Wild Card II", false));
        skillSetItems.Add(new SkillSetItem("Wild Card III", false));
        skillSetItems.Add(new SkillSetItem("Responsible Person", false));
        skillSetItems.Add(new SkillSetItem("Responsible Person II", false));
        skillSetItems.Add(new SkillSetItem("Hook, Line & Sinker",false));

        foreach (SkillSetItem item in skillSetItems) {
            GameObject newItem = Instantiate(skillSetItemPrefab) as GameObject;
            SkillSetItemController controller = newItem.GetComponent<SkillSetItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
            string textName = item.Name;
            print("TEXT NAME :" + textName);
            newItems.Add(newItem);
        }
    }

    public void skillBtnAction (string tag) {
        skillSetListPanel.SetActive(true);
        populateSkillSetList();
    }

    public void OnClose() {
        skillSetListPanel.SetActive(false);
    }
}
