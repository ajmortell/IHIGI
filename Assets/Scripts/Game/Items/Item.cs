using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private int itemID;
    private string itemName;
    private string itemDescription;
    private Texture2D itemImage;
    private int itemQty;
    public enum ItemType { CONSUME,USE,EQUIP,SPEECH };
    public ItemType itemType;

	public Item (int itemid, string itemname, string itemdescription, Texture2D itemimage, int itemqty, ItemType itemtype) {
        itemID = itemid;
        itemName = itemname;
        itemDescription = itemdescription;
        itemImage = itemimage;
        itemQty = itemqty;
        itemType = itemtype;
        
    }
}
