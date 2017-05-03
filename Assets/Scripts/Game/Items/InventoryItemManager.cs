using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class InventoryItemManager : MonoBehaviour {

    public GameObject ContentPanel;
    public GameObject inventoryItemPrefab;
    private List<InventoryItem> inventoryItems;

    private void Awake() {
        layoutItems();
    }

    public void cleanUp() {
        GameObject[] newItems = GameObject.FindGameObjectsWithTag("InventoryItemFab");
        foreach (InventoryItem oldItem in inventoryItems) {
            inventoryItems.Clear();
        }
        foreach (GameObject fabObjects in newItems) {
            Destroy(fabObjects);
        }
    }

    /*
    public Sprite gatherSprites()
    {
        return;
    }
    */

    public void layoutItems() {
        inventoryItems = new List<InventoryItem>();
        cleanUp();
        int count = -1;
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Items/itemsSheet_01");

        /*
        foreach (Sprite s in sprites) {
            count++;
            print("sprite count: " + count + "sprites name: " + sprites[count].name);
            if (count >= sprites.Length) {
                count = -1;
            }
        }
        */

        inventoryItems.Add(new InventoryItem(sprites[0], 01, 1, sprites[0].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[1], 02, 1, sprites[1].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[2], 03, 1, sprites[2].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[3], 04, 1, sprites[3].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[4], 05, 1, sprites[4].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[5], 06, 1, sprites[5].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[6], 07, 1, sprites[6].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[7], 08, 1, sprites[7].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[8], 09, 5, sprites[8].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[9], 10, 1, sprites[9].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[10], 11, 1, sprites[10].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[11], 12, 1, sprites[11].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[12], 13, 1, sprites[12].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[13], 14, 1, sprites[13].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[14], 15, 1, sprites[14].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[15], 16, 1, sprites[15].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[16], 17, 1, sprites[16].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[17], 18, 1, sprites[17].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[18], 19, 1, sprites[18].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[19], 20, 1, sprites[19].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[20], 21, 1, sprites[20].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[21], 22, 1, sprites[21].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[22], 23, 3, sprites[22].name, ""));
        inventoryItems.Add(new InventoryItem(sprites[23], 24, 1, sprites[23].name, ""));

        foreach (InventoryItem item in inventoryItems)
        {
            GameObject newItem = Instantiate(inventoryItemPrefab) as GameObject;
            InventoryItemController controller = newItem.GetComponent<InventoryItemController>();
            controller.ID = item.ID;
            controller.Qty.text = item.Qty.ToString();
            controller.Name.text = item.Name;
            controller.Description.text = item.Description;
            controller.Image.sprite = item.Image;
            newItem.transform.SetParent(ContentPanel.transform);
            newItem.transform.localScale = Vector3.one;
        }
    }
}
