using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem {

    public Sprite Image;
    public int ID;
    public int Qty;
    public string Name;
    public string Description;
    
    public InventoryItem( Sprite image, int id, int qty, string name, string description) {
        Image = image;
        ID = id;
        Name = name;
        Description = description;
        Qty = qty;
    }
}
