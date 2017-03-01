using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MailList : MonoBehaviour {

    //public GameObject ContentPanel;
   // public GameObject mailItemPrefab;

 //   public List<MailItem> mailItems;

  

    void Start() {
/*
        mailItems = new List<MailItem>();

        mailItems.Add(new MailItem("#### #######", "#####", "########### ### ############### # ######### ##########?", "8:00 am"));
        mailItems.Add(new MailItem("#### #######", "#####", "########### ### ############### # ######### ##########?", "2:00 pm"));

        foreach (MailItem item in mailItems) {

            GameObject newItem = Instantiate(mailItemPrefab) as GameObject; // this is the cell that displays the mail item data
            MailItemController controller = newItem.GetComponent<MailItemController>(); // this is the text for the item. will replace with sprite font
            controller.Sender.text = item.Sender;
            controller.Subject.text = item.Subject;
            controller.Message.text = item.Message;
            controller.TimeStamp.text = item.TimeStamp;
            newItem.transform.SetParent(ContentPanel.transform);//parent = ContentPanel.transform;
            newItem.transform.localScale = Vector3.one;

        }*/
    }
}
