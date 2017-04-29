using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class FeedSectionManager : MonoBehaviour {

    //public Sprite[] FeedPhotos;
    public GameObject ContentPanel;
    public GameObject feedItemPrefab;
    private List<FeedItem> feedItems;

    private void Awake() {
        layoutItems();
    }

    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("FeedItemFab");
        foreach (FeedItem oldItem in feedItems) {
            feedItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
        }
    }

    public void layoutItems() {

        feedItems = new List<FeedItem>();
        cleanUp();

        feedItems.Add(new FeedItem("Adam", "MONDAY", "00:00 AM", "Lorum Ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum.", "0", "0"));
        feedItems.Add(new FeedItem("Christine", "MONDAY", "00:00 AM", "Lorum Ipsum lorum ipsum lorum ipsum lorum ipsum.", "0", "0"));
        feedItems.Add(new FeedItem("Link", "MONDAY", "00:00 AM", "Lorum Ipsum lorum ipsum.", "0", "0"));
        feedItems.Add(new FeedItem("Shepard", "TUESDAY", "00:00 AM", "Lorum Ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum.", "0", "0"));

        foreach (FeedItem item in feedItems) {
            GameObject newItem = Instantiate(feedItemPrefab) as GameObject;
            FeedItemController controller = newItem.GetComponent<FeedItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }

    public void OnSelection(GameObject obj) {
        string tagName = obj.tag;
        layoutItems();
    }
}
