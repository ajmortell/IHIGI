using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spam : MonoBehaviour {

    public GameObject ContentPanel;
    public GameObject mailItemPrefab;

    ArrayList mailItems;

    void Start()
    {
        mailItems = new ArrayList() {

            new MailItem("Adam Mortell",
                       "Lorum",
                       "We have looked over your CV and Lorum ipsum lorum ipsum. When is the best time to lorum ipsum. Lorum ipsum?",
                       "8:00 am"
                       ),
            new MailItem("Christine Delgado",
                       "Lorum ipsum",
                       "Lets get together and lorum ipsum?",
                       "12:00 pm"
                       ),
            new MailItem("Jack Skellington",
                       "Lorum ipsum",
                       "Lets get together and lorum ipsum?",
                       "12:00 pm"
                       )

        };

        foreach (MailItem item in mailItems)
        {

            GameObject newItem = Instantiate(mailItemPrefab) as GameObject;
            MailItemController controller = newItem.GetComponent<MailItemController>();
            controller.Sender.text = item.Sender;
            controller.Subject.text = item.Subject;
            controller.Message.text = item.Message;
            controller.TimeStamp.text = item.TimeStamp;
            newItem.transform.SetParent(ContentPanel.transform);//parent = ContentPanel.transform;
            newItem.transform.localScale = Vector3.one;

        }
    }
}
