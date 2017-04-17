using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ContactsSectionManager : MonoBehaviour {

    private int listCounter;
    private int tapcounter;
    private bool isContactsOpen;
    private string currentLetter;
    private List<ContactsItem> contactsItems;
    private List<GameObject> newItems;
    public GameObject contactsListPanel;
    public GameObject ContentPanel;
    public GameObject contactsItemPrefab;
    private GameObject letterSeperatorPanel;
    private GameObject letterBtnObj;
    private GameObject letterObj;
    private Letter letter;
    private Button letterBtn;    
    
    private void Awake() {
        listCounter = 0;
        tapcounter = 0;
        isContactsOpen = false;
        letterSeperatorPanel = GameObject.FindGameObjectWithTag("LetterSeperatorPanel");
        letterSeperatorPanel.SetActive(false);   
        contactsItems = new List<ContactsItem>();
        newItems = new List<GameObject>();
        contactsListPanel = GameObject.FindGameObjectWithTag("ContactsListPanel");
        contactsListPanel.SetActive(false);
        letterBtnObj = GameObject.FindGameObjectWithTag("LetterBtn");
        letterObj = GameObject.FindGameObjectWithTag("Letter");
        letter = letterObj.GetComponent<Letter>();
        letterBtn = letterBtnObj.GetComponent<Button>();
        letterBtn.onClick.AddListener(() => letterBtnAction(letter.returnLetter()));      
    }

    public void calculateListSize() {
        int size = 0;

        for (int count = listCounter; count <= listCounter; count--) {
            if (count == 0) {
                return;
            }
            size = size + 8;
        }
            size = 0;
    }

    public void addSeperatorPanel() {
        letterSeperatorPanel.SetActive(true);
    }

    void letterBtnAction(string letter) {
        tapcounter++;
        if (tapcounter > 1) {
            tapcounter = 0;
            listCounter = 0;
            contactsListPanel.SetActive(false);
            addContacts("0");
            cleanUp();
        } else {
            contactsListPanel.SetActive(true);
            addContacts(letter);
        }
    }
    
    public void cleanUp() { 
        foreach (ContactsItem oldItem in contactsItems) {
            contactsItems.Clear();    
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);   
        }
    }

    public void addContacts(string letter) {
        currentLetter = letter;
        contactsItems = new List<ContactsItem>();
        cleanUp();  
              
        switch (letter) {
            case "A":             
                contactsItems.Add(new ContactsItem("Barry Alan"));
                contactsItems.Add(new ContactsItem("Johnny Anarchy"));
                contactsItems.Add(new ContactsItem("Samus Aran"));
                break;

            case "B":
                print("CASE B");
                break;

            case "C":
                print("CASE C");
                break;

            case "D":
                print("CASE D");
                break;

            case "E":
                print("CASE E");
                break;

            case "F":
                print("CASE F");
                break;

            case "G":
                print("CASE G");
                break;

            case "H":
                print("CASE H");
                break;

            case "I":
                print("CASE I");
                break;

            case "J":
                print("CASE J");
                break;

            case "K":
                print("CASE K");
                break;

            case "L":
                print("CASE L");
                break;

            case "M": 
                contactsItems.Add(new ContactsItem("Adam Mortell"));
                contactsItems.Add(new ContactsItem("Christine Mortell"));
                contactsItems.Add(new ContactsItem("Tony Montana"));
                contactsItems.Add(new ContactsItem("Mario Mario"));
                contactsItems.Add(new ContactsItem("Luigi Mario"));
                contactsItems.Add(new ContactsItem("Tom Morello"));
                contactsItems.Add(new ContactsItem("Dave Mustane"));            
                break;

            case "N":
                print("CASE N");
                break;

            case "O":
                print("CASE O");
                break;

            case "P":
                print("CASE P");
                break;

            case "Q":
                print("CASE Q");
                break;

            case "R":
                print("CASE R");
                break;
                
            case "S":
                print("CASE S");
                break;

            case "T":
                print("CASE T");
                break;

            case "U":
                print("CASE U");
                break;

            case "V":
                print("CASE V");
                break;

            case "W":
                print("CASE W");
                break;

            case "X":
                print("CASE X");
                break;

            case "Y":
                print("CASE Y");
                break;

            case "Z":
                print("CASE Z");
                break;
            case "0":
                print("No Entry");
                break;
        }

        foreach (ContactsItem item in contactsItems) {
            GameObject newItem = Instantiate(contactsItemPrefab) as GameObject;
            ContactsItemController controller = newItem.GetComponent<ContactsItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
            listCounter++;
            newItems.Add(newItem);

        }
    }

    public void addNewContact(string newContact)
    {
        contactsItems = new List<ContactsItem>();
        contactsItems.Add(new ContactsItem(newContact));
       
        foreach (ContactsItem item in contactsItems)
        {
            GameObject newItem = Instantiate(contactsItemPrefab) as GameObject;
            ContactsItemController controller = newItem.GetComponent<ContactsItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }

    public void OnAddNewContact(string contact) {
        addNewContact(contact);
    }

    private void OnDestroy() {
        listCounter = 0;
        letterBtn.onClick.RemoveAllListeners();
        print("DESTROYED ALPHABETT ITEM");
    }

}
