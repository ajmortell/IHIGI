using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MailSectionManager : MonoBehaviour
{
    public GameObject ContentPanel;
    public GameObject mailItemPrefab;
    private List<MailItem> mailItems;
    
    private void Awake() {
        layoutItems("InboxButton");
    }

    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("MailItemFab");
        foreach (MailItem oldItem in mailItems) {
            mailItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
            //Debug.Log("DESTROYED THAT @#$% YO!");
        }
    }

    public void layoutItems(string button) {

        mailItems = new List<MailItem>();
        cleanUp();

        switch (button) {

            case "InboxButton":
                mailItems.Add(new MailItem("#", "#", "#?", "8:00 am"));
                break;
            case "SentButton":
                mailItems.Add(new MailItem("##  ##", "##  ##", "##  ##?", "9:00 am"));
                mailItems.Add(new MailItem("##  ##", "##  ##", "##  ##?", "9:00 am"));
                break;
            case "SpamButton":
                mailItems.Add(new MailItem("##   ##   ##", "##   ##   ##", "##   ##   ##?", "1:00 am"));
                mailItems.Add(new MailItem("##   ##   ##", "##   ##   ##", "##   ##   ##?", "3:00 pm"));
                mailItems.Add(new MailItem("##   ##   ##", "##   ##   ##", "##   ##   ##?", "10:00 am"));
                break;
            case "TrashButton":
                mailItems.Add(new MailItem("##    ##    ##    ##", "##    ##    ##    ##", "##    ##    ##    ##    ##?", "12:00 pm"));
                mailItems.Add(new MailItem("##    ##    ##    ##", "##    ##    ##    ##", "##    ##    ##    ##    ##?", "2:00 pm"));
                mailItems.Add(new MailItem("##    ##    ##    ##", "##    ##    ##    ##", "##    ##    ##    ##    ##?", "8:00 am"));
                mailItems.Add(new MailItem("##    ##    ##    ##", "##    ##    ##    ##", "##    ##    ##    ##    ##?", "2:00 pm"));
                break;
        }

        foreach (MailItem item in mailItems) {

            GameObject newItem = Instantiate(mailItemPrefab) as GameObject;
            MailItemController controller = newItem.GetComponent<MailItemController>();
            controller.Sender.text = item.Sender;
            controller.Subject.text = item.Subject;
            controller.Message.text = item.Message;
            controller.TimeStamp.text = item.TimeStamp;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
        //Debug.Log("LIST COUNT: " + mailItems.Count);
    }
    
    public void OnSelection(GameObject obj) {
        
        string tagName = obj.tag;

        switch (tagName) {
            case "InboxButton" :
                //Debug.Log(tagName + " SELECTED");
                layoutItems(tagName);
                break;
            case "SentButton"  :
                //Debug.Log(tagName + " SELECTED");
                layoutItems(tagName);
                break;
            case "SpamButton"  :
                //Debug.Log(tagName + " SELECTED");
                layoutItems(tagName);
                break;
            case "TrashButton" :
                //Debug.Log(tagName + " SELECTED");
                layoutItems(tagName);
                break;
        }
    }
}