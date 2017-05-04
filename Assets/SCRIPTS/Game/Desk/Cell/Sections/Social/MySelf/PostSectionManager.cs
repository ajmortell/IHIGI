using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class PostSectionManager : MonoBehaviour {

    public Sprite[] PostPhotos;
    public GameObject ContentPanel;
    public GameObject postItemPrefab;
    private List<PostItem> postItems;

    private void Awake() {
        //cleanUp();
    }

    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("PostItemFab");
        foreach (PostItem oldItem in postItems) {
            postItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
        }
    }

    public void postItem() {

        postItems = new List<PostItem>();
        
        postItems.Add(new PostItem(PostPhotos[0],"Adam", "MONDAY", "00:00 AM", "Lorum Ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum lorum ipsum.", "0", "0"));
        
        foreach (PostItem item in postItems) {
            GameObject newItem = Instantiate(postItemPrefab) as GameObject;
            PostItemController controller = newItem.GetComponent<PostItemController>();
            controller.Name.text = item.Name;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }

    public void OnPost() {
        postItem();
    }

}
