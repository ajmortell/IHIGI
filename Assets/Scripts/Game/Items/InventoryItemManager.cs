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
                inventoryItems.Add(new InventoryItem(shirtsSprites[9], 10, 1, shirtsSprites[9].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[10], 11, 1, shirtsSprites[10].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[11], 12, 1, shirtsSprites[11].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[12], 13, 1, shirtsSprites[12].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[13], 14, 1, shirtsSprites[13].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[14], 15, 1, shirtsSprites[14].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[15], 16, 1, shirtsSprites[15].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[16], 17, 1, shirtsSprites[16].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[17], 18, 1, shirtsSprites[17].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[18], 19, 1, shirtsSprites[18].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[19], 20, 1, shirtsSprites[19].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[20], 21, 1, shirtsSprites[20].name, ""));
                inventoryItems.Add(new InventoryItem(shirtsSprites[21], 22, 1, shirtsSprites[21].name, ""));
                break;

            case "shoesBtn":
                inventoryItems.Add(new InventoryItem(shoesSprites[0], 23, 1, shoesSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[1], 24, 1, shoesSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[2], 25, 1, shoesSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[3], 26, 1, shoesSprites[3].name, ""));
                inventoryItems.Add(new InventoryItem(shoesSprites[4], 27, 1, shoesSprites[4].name, ""));

                break;

            case "consumablesBtn":
                inventoryItems.Add(new InventoryItem(consumablesSprites[0], 28, 1, consumablesSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(consumablesSprites[1], 29, 1, consumablesSprites[1].name, ""));
                break;

            case "awardsBtn":
                inventoryItems.Add(new InventoryItem(awardsSprites[0], 30, 1, awardsSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[1], 31, 1, awardsSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[2], 32, 1, awardsSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[3], 33, 1, awardsSprites[3].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[4], 33, 1, awardsSprites[4].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[5], 33, 1, awardsSprites[5].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[6], 33, 1, awardsSprites[6].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[7], 33, 1, awardsSprites[7].name, ""));
                inventoryItems.Add(new InventoryItem(awardsSprites[8], 33, 1, awardsSprites[8].name, ""));
                break;

            case "pantsBtn":
                inventoryItems.Add(new InventoryItem(pantsSprites[0], 34, 1, pantsSprites[0].name, ""));
                inventoryItems.Add(new InventoryItem(pantsSprites[1], 35, 1, pantsSprites[1].name, ""));
                inventoryItems.Add(new InventoryItem(pantsSprites[2], 36, 1, pantsSprites[2].name, ""));
                inventoryItems.Add(new InventoryItem(pantsSprites[3], 37, 1, pantsSprites[3].name, ""));
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
