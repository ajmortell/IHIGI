using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ContactsSectionManager : MonoBehaviour {

    private int listCounter;
    private int tapcounter;
    private GameObject letterSeperatorPanel;

    private bool canOpenContacts;
    private bool isContactsOpen;
    
    private List<ContactsItem> contactsItems;
    private GameObject contactsListPanel;
    public GameObject ContentPanel;
    public GameObject contactsItemPrefab;

    private GameObject letterBtnObj;
    private Button letterBtn;    
    private GameObject letterObj;
    private Letter letter;
    private string currentLetter;

    private void Awake() {

        listCounter = 0;
        tapcounter = 0;
        letterSeperatorPanel = GameObject.FindGameObjectWithTag("LetterSeperatorPanel");
        letterSeperatorPanel.SetActive(false);
        
        canOpenContacts = true;
        isContactsOpen = false;

        contactsItems = new List<ContactsItem>();
        contactsListPanel = GameObject.FindGameObjectWithTag("ContactsListPanel");
        contactsListPanel.SetActive(false);

        letterBtnObj = GameObject.FindGameObjectWithTag("LetterBtn");
        letterObj = GameObject.FindGameObjectWithTag("Letter");
        letter = letterObj.GetComponent<Letter>();    
        letterBtn = letterBtnObj.GetComponent<Button>();
        letterBtn.onClick.AddListener(() => letterBtnAction(letter.returnLetter()));

    }

    public void calculateListSize(bool isOpen) {
        int size = 0;
        

        if (isOpen == true) {
            for (int count = listCounter; count <= listCounter; count--) {
                if (count == 0) {
                   // print("Count = ZERO: " + count);
                    return;
                }
                size = size + 8;
                //print("SIZE: " + size);
            }
        } else {
            size = 0;
        }

    }

    public void addSeperatorPanel() {
        letterSeperatorPanel.SetActive(true);
    }

    void letterBtnAction(string letter) {
        
        tapcounter++;
        print(letter + " TAP COUNT: " + tapcounter);

        if (canOpenContacts == true) {

            canOpenContacts = false;
            isContactsOpen = true;
            contactsListPanel.SetActive(true);
            calculateListSize(true);
            addContacts(letter);

        } else {
            if (tapcounter >= 1) {
                tapcounter = 0;
                addContacts("0");
                cleanUp();
                canOpenContacts = true;
                isContactsOpen = false;
                contactsListPanel.SetActive(false);
                listCounter = 0;
            } else {
               
                addContacts("0");
                cleanUp();
                canOpenContacts = true;
                isContactsOpen = false;
                contactsListPanel.SetActive(false);
                listCounter = 0;
                contactsListPanel.SetActive(true);
                calculateListSize(true);
                addContacts(letter);
            }
        }       
    }

    public void letterBtnCloseAction() {

    }
    
    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("ContactsItemFab");
        //print(" +++ CLEANUP: NEW ITEMS - COUNT: " + newItems.Length);
        foreach (ContactsItem oldItem in contactsItems) {
            contactsItems.Clear();
            print(" +++ CLEANUP: CLEARED CONTACTS ITEMS - COUNT: " + contactsItems.Count);
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
            print(" +++ CLEANUP: DESTROYED FAB OBJECT");
        }
    }

    public void addContacts(string letter) {
        currentLetter = letter;
        print("CURRENT LETTER: " + currentLetter);
        contactsItems = new List<ContactsItem>();
        cleanUp();
        //print(" ~~~~~~~~~ CONTACTS ITEMS COUNT: "+contactsItems.Count);
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

    void Update() {
     
    }

    private void OnDestroy() {
        listCounter = 0;
        letterBtn.onClick.RemoveAllListeners(); ; //AddListener(() => letterBtnAction(letter.returnLetter()));
        print("DESTROYED ALPHABETT ITEM");
    }

}
