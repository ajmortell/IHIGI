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
        layoutItems("shirtsBtn");

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


    public void layoutItems(string btnName) {

        inventoryItems = new List<InventoryItem>();
        cleanUp();

        Sprite[] shirtsSprites = Resources.LoadAll<Sprite>("Sprites/Items/shirtsSheet");
        Sprite[] shoesSprites = Resources.LoadAll<Sprite>("Sprites/Items/shoesSheet");
        Sprite[] consumablesSprites = Resources.LoadAll<Sprite>("Sprites/Items/consumablesSheet");
        Sprite[] awardsSprites = Resources.LoadAll<Sprite>("Sprites/Items/awardsSheet");
        Sprite[] pantsSprites = Resources.LoadAll<Sprite>("Sprites/Items/pantsSheet");

        switch (btnName)
        {
            case "shirtsBtn":
                inventoryItems.Add(new InventoryItem(shirtsSprites[0], 01, 1, shirtsSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[1], 02, 1, shirtsSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[2], 03, 1, shirtsSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[3], 04, 1, shirtsSprites[3].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[4], 05, 1, shirtsSprites[4].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[5], 06, 1, shirtsSprites[5].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[6], 07, 1, shirtsSprites[6].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[7], 08, 1, shirtsSprites[7].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[8], 09, 1, shirtsSprites[8].name, ""));
                break;

            case "shoesBtn":
                inventoryItems.Add(new InventoryItem(shoesSprites[0], 10, 1, shoesSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[1], 11, 1, shoesSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[2], 12, 1, shoesSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[3], 13, 1, shoesSprites[3].name, ""));
         
                break;

            case "consumablesBtn":
                inventoryItems.Add(new InventoryItem(consumablesSprites[0], 14, 1, consumablesSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(consumablesSprites[1], 15, 1, consumablesSprites[1].name, ""));
                break;

            case "awardsBtn":
                inventoryItems.Add(new InventoryItem(awardsSprites[0], 16, 1, awardsSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[1], 17, 1, awardsSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[2], 18, 1, awardsSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[3], 19, 1, awardsSprites[3].name, ""));
               
                break;

            case "pantsBtn":
                inventoryItems.Add(new InventoryItem(pantsSprites[0], 20, 1, pantsSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(pantsSprites[1], 21, 1, pantsSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(pantsSprites[2], 22, 1, pantsSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(pantsSprites[3], 23, 1, pantsSprites[3].name, ""));
                break;
        }
        /*
        foreach (Sprite s in sprites) {
            count++;
            print("sprite count: " + count + "sprites name: " + sprites[count].name);
            if (count >= sprites.Length) {
                count = -1;
            }
        }
        */

        foreach (InventoryItem item in inventoryItems) {
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
    
    public void OnButtonPress(Button btn) {

        layoutItems(btn.name);
    }
}
