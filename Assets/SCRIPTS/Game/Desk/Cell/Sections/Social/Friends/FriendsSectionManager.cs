using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class FriendsSectionManager : MonoBehaviour {

    public Sprite[] FriendPhotos;
    public GameObject ContentPanel;
    public GameObject friendItemPrefab;
    private List<FriendItem> friendItems;

    private void Awake() {
        layoutItems();
    }

    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("FriendItemFab");
        foreach (FriendItem oldItem in friendItems) {
            friendItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
        }
    }

    public void layoutItems() {

        friendItems = new List<FriendItem>();
        cleanUp();

        friendItems.Add(new FriendItem(FriendPhotos[0], "Adam"));
        friendItems.Add(new FriendItem(FriendPhotos[1], "Christine"));
        friendItems.Add(new FriendItem(FriendPhotos[2], "Bob"));
        friendItems.Add(new FriendItem(FriendPhotos[3], "Zelda"));
        friendItems.Add(new FriendItem(FriendPhotos[4], "Samus"));
        friendItems.Add(new FriendItem(FriendPhotos[5], "Link"));
        friendItems.Add(new FriendItem(FriendPhotos[6], "Mario"));
        friendItems.Add(new FriendItem(FriendPhotos[7], "Luigi"));
        friendItems.Add(new FriendItem(FriendPhotos[8], "Einstein"));
        friendItems.Add(new FriendItem(FriendPhotos[9], "Morty"));
        friendItems.Add(new FriendItem(FriendPhotos[10], "Rick"));
        friendItems.Add(new FriendItem(FriendPhotos[11], "Batman"));

        foreach (FriendItem item in friendItems) {
            GameObject newItem = Instantiate(friendItemPrefab) as GameObject;
            FriendItemController controller = newItem.GetComponent<FriendItemController>();
            controller.Name.text = item.Name;
            
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
