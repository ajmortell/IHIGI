using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class SkillMenuItemManager : MonoBehaviour {

    public GameObject ContentPanel;
    public GameObject skillMenuItemPrefab;
    private List<SkillMenuItem> skillMenuItems;
    private int skillValue;
    private string skillValueString;

    private void Awake() {
        skillValue = 0;
        skillValueString = skillValue.ToString();
        layoutItems();       
    }

    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("SkillMenuItemFab");
        foreach (SkillMenuItem oldItem in skillMenuItems) {
            skillMenuItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
        }
    }

    public void layoutItems() {

        skillMenuItems = new List<SkillMenuItem>();
        cleanUp();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        SkillData skills = player.GetComponent<SkillData>();

        System.Reflection.FieldInfo[] fields = skills.GetType().GetFields();
        foreach (System.Reflection.FieldInfo field in fields) {
            skillValueString = field.GetValue(skills).ToString();
            skillMenuItems.Add(new SkillMenuItem(field.Name, skillValueString));
        }

        foreach (SkillMenuItem item in skillMenuItems) {
            GameObject newItem = Instantiate(skillMenuItemPrefab) as GameObject;
            SkillMenuItemController controller = newItem.GetComponent<SkillMenuItemController>();
            controller.Name.text = item.Name;
            controller.Value.text = item.Value;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }
}
