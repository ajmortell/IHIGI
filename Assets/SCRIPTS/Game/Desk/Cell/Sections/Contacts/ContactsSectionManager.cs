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
    private int contactIndex;
    private List<ContactsItem> contactsItems;//
    private List<GameObject> newItems;//

    public GameObject contactsListPanel;
    public GameObject ContentPanel;//
    public GameObject contactsItemPrefab;//
    private GameObject letterBtnObj;
    private GameObject letterObj;

    private Letter letter;
    private Button letterBtn;    
    
    private void Awake() {
        listCounter = 0;
        tapcounter = 0;
        isContactsOpen = false;

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

    public int calculateListHeight() {
        int height = 0;
        for (int count = listCounter; count <= listCounter; count--) {
            if (count == 0) {
                break;
            } else {
                height = height + 8;
            }
        }
        return height;
    }

    public int calculateListDistance() {
        int distance = calculateListHeight();    
        return distance;
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
            int d = calculateListDistance();
            print("DISTANCE: " + d);
            
        }
    }

    public string getCurrentLetter()
    {
        return currentLetter;
    }
    
    public void calculateCurrentLetterIndex()
    {

    }


    public void cleanUp() { 
        foreach (ContactsItem oldItem in contactsItems) {
            contactsItems.Clear();    
        }
        foreach (GameObject fabObjects in newItems) {
            DestroyImmediate(fabObjects);   
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
                contactsItems.Add(new ContactsItem("Josh Benson"));
                contactsItems.Add(new ContactsItem("David Bowie"));
                break;

            case "C":
                contactsItems.Add(new ContactsItem("John Constantine"));
                break;

            case "D":
                contactsItems.Add(new ContactsItem("Tony Danza"));
                contactsItems.Add(new ContactsItem("Glen Danzig"));
                contactsItems.Add(new ContactsItem("Helen Delgado"));
                contactsItems.Add(new ContactsItem("Severo Delgado"));
                contactsItems.Add(new ContactsItem("Judge Dread"));
                break;

            case "E":
                contactsItems.Add(new ContactsItem("Trash Englebretzen"));
                break;

            case "F":
                contactsItems.Add(new ContactsItem("Guy Fawkes"));
                contactsItems.Add(new ContactsItem("Chris Farley"));
                contactsItems.Add(new ContactsItem("Carrie Fisher"));
                contactsItems.Add(new ContactsItem("Dan Folgleberg"));
                contactsItems.Add(new ContactsItem("Black Francis"));
                break;

            case "G":
                contactsItems.Add(new ContactsItem("Janeane Garafalo"));
                contactsItems.Add(new ContactsItem("Bill Gates"));
                break;

            case "H":
                contactsItems.Add(new ContactsItem("Rob Halford"));
                contactsItems.Add(new ContactsItem("Ziggy Hop"));
                contactsItems.Add(new ContactsItem("Aldous Huxley"));
                break;

            case "I":
                contactsItems.Add(new ContactsItem("Ironamn7"));
                break;

            case "J":
                contactsItems.Add(new ContactsItem("Dick Johnson"));
                contactsItems.Add(new ContactsItem("Harry Johnson"));
                contactsItems.Add(new ContactsItem("Jenk Johnson"));
                contactsItems.Add(new ContactsItem("John Johnson"));
                contactsItems.Add(new ContactsItem("Peter Johnson"));
                contactsItems.Add(new ContactsItem("Sandy Johnson"));

                break;

            case "K":
                contactsItems.Add(new ContactsItem("Freddy Krueger"));
                break;

            case "L":
                contactsItems.Add(new ContactsItem("Wude Law"));
                contactsItems.Add(new ContactsItem("Michael Linsner"));
                break;

            case "M":
                contactsItems.Add(new ContactsItem("Adam Mortell"));
                contactsItems.Add(new ContactsItem("Christine Mortell"));
                contactsItems.Add(new ContactsItem("Mario Mario"));
                contactsItems.Add(new ContactsItem("Luigi Mario"));
                contactsItems.Add(new ContactsItem("Tom Morello"));
                contactsItems.Add(new ContactsItem("Bill Murray"));
                contactsItems.Add(new ContactsItem("Dave Mustane"));
                break;

            case "N":
                contactsItems.Add(new ContactsItem("Friedrich Nietzsche"));
                contactsItems.Add(new ContactsItem("Bill Nye"));
                break;

            case "O":
                contactsItems.Add(new ContactsItem("Karen O."));
                contactsItems.Add(new ContactsItem("Conan O'Brien"));
                break;

            case "P":
                contactsItems.Add(new ContactsItem("Peter Parker"));
                contactsItems.Add(new ContactsItem("Senator Palapatine"));
                break;

            case "Q":
                contactsItems.Add(new ContactsItem("Alan Quartermain"));
                break;

            case "R":
                contactsItems.Add(new ContactsItem("Trent Reznor"));
                break;

            case "S":
                contactsItems.Add(new ContactsItem("Han Solo"));
                contactsItems.Add(new ContactsItem("Stan Solo"));
                break;

            case "T":
                contactsItems.Add(new ContactsItem("Serj Tankian"));
                contactsItems.Add(new ContactsItem("Channing Tatum"));
                contactsItems.Add(new ContactsItem("Mike Tyson"));
                break;

            case "U":
                contactsItems.Add(new ContactsItem("Skeet Ulrich"));
                contactsItems.Add(new ContactsItem("Jay Underwood"));
                break;

            case "V":
                contactsItems.Add(new ContactsItem("Jan-Michael Vincent"));
                break;

            case "W":
                contactsItems.Add(new ContactsItem("Andy Wachowski"));
                contactsItems.Add(new ContactsItem("Larry Wachowski"));
                contactsItems.Add(new ContactsItem("Meg White"));
                break;

            case "X":
                contactsItems.Add(new ContactsItem("Charly Xavier"));
                break;

            case "Y":
                contactsItems.Add(new ContactsItem("Al Yankovic"));
                contactsItems.Add(new ContactsItem("Thom Yorke"));
                contactsItems.Add(new ContactsItem("Love Young"));
                break;

            case "Z":
                contactsItems.Add(new ContactsItem("Mork Zuckleberg"));

                break;
            case "0":

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

    private void OnDestroy() {    
        listCounter = 0;
        tapcounter = 0;
        letterBtn.onClick.RemoveAllListeners();
    }

}
