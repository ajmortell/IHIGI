using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class PhoneSectionManager : MonoBehaviour
{
    private GameObject panel;
    public GameObject ContentPanel;
    public GameObject phoneAlphabetItemPrefab;
    private List<AlphabetItem> alphabetItems;
    private int letterIndex;

    private void Awake() {
        panel = GameObject.FindGameObjectWithTag("PhonePanel");
        addLetters();
    }

    public void addLetters() {
        alphabetItems = new List<AlphabetItem>();

        alphabetItems.Add(new AlphabetItem("A"));
        alphabetItems.Add(new AlphabetItem("B"));
        alphabetItems.Add(new AlphabetItem("C"));
        alphabetItems.Add(new AlphabetItem("D"));
        alphabetItems.Add(new AlphabetItem("E"));
        alphabetItems.Add(new AlphabetItem("F"));
        alphabetItems.Add(new AlphabetItem("G"));
        alphabetItems.Add(new AlphabetItem("H"));
        alphabetItems.Add(new AlphabetItem("I"));
        alphabetItems.Add(new AlphabetItem("J"));
        alphabetItems.Add(new AlphabetItem("K"));
        alphabetItems.Add(new AlphabetItem("L"));
        alphabetItems.Add(new AlphabetItem("M"));
        alphabetItems.Add(new AlphabetItem("N"));
        alphabetItems.Add(new AlphabetItem("O"));
        alphabetItems.Add(new AlphabetItem("P"));
        alphabetItems.Add(new AlphabetItem("Q"));
        alphabetItems.Add(new AlphabetItem("R"));
        alphabetItems.Add(new AlphabetItem("S"));
        alphabetItems.Add(new AlphabetItem("T"));
        alphabetItems.Add(new AlphabetItem("U"));
        alphabetItems.Add(new AlphabetItem("V"));
        alphabetItems.Add(new AlphabetItem("W"));
        alphabetItems.Add(new AlphabetItem("X"));
        alphabetItems.Add(new AlphabetItem("Y"));
        alphabetItems.Add(new AlphabetItem("Z"));

        foreach (AlphabetItem item in alphabetItems) {
            GameObject newItem = Instantiate(phoneAlphabetItemPrefab) as GameObject;
            AlphabetItemController controller = newItem.GetComponent<AlphabetItemController>();
            controller.Letter.text = item.Letter;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }

    public void OnClose() {
        //panel.SetActive(false);
        //destroy
    }
}
