using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ContactsSectionManager : MonoBehaviour {

    public GameObject ContentPanel;
    public GameObject contactsItemPrefab;
    private List<ContactsItem> contactsItems;

    bool canOpenContacts;
    bool isContactsOpen;

    private GameObject contactsListPanel;
    private Button letterBtn;
    private GameObject letterBtnObj;
    private GameObject letterObj;

    private void Awake() {
        canOpenContacts = false;
        isContactsOpen = false;
        //cleanUp();

        contactsListPanel = GameObject.FindGameObjectWithTag("ContactsListPanel");
        letterBtnObj = GameObject.FindGameObjectWithTag("LetterBtn");
        letterObj = GameObject.FindGameObjectWithTag("Letter");
        Letter letter = letterObj.GetComponent<Letter>();
        
        letterBtn = letterBtnObj.GetComponent<Button>();
        letterBtn.onClick.AddListener(() => letterBtnAction(letter.returnLetter()));
        contactsListPanel.SetActive(false);
    }

    void letterBtnAction(string letter)
    {
        Debug.Log("letterBtn pressed :  ");
        contactsListPanel.SetActive(true);
        addContacts(letter);
    }



    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("ContactsItemFab");
        foreach (ContactsItem oldItem in contactsItems) {
            contactsItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
        }
    }

    public void addContacts(string letter) {
        print("addContacts called...");
        contactsItems = new List<ContactsItem>();
        switch (letter)
        {
            case "A":
                print("CASE A");
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
                print("CASE M");
                contactsItems.Add(new ContactsItem("Adam Mortell"));
                contactsItems.Add(new ContactsItem("Christine Mortell"));
                contactsItems.Add(new ContactsItem("Tony Montana"));
                contactsItems.Add(new ContactsItem("Mario"));
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
        }

        foreach (ContactsItem item in contactsItems) {
            GameObject newItem = Instantiate(contactsItemPrefab) as GameObject;
            ContactsItemController controller = newItem.GetComponent<ContactsItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }

    public void setCanOpen() {
        canOpenContacts = true;
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

    void Update()
    {
       // if(canOpenContacts != true)
       // {
            //canOpenContacts = false;
            //isContactsOpen = true;
            //if(isContactsOpen == true)
            //{
            //    ContentPanel.SetActive(true);
            //    isContactsOpen = false;
            //    addContacts();
           // }
       // }
    }

}
