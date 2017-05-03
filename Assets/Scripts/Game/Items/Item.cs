using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private bool isUnlocked;
    private bool isOwned;

    public Item () {

        isUnlocked = false;
        isOwned = false;
    }

    public void setIsUnlocked(bool isit) {
        isUnlocked = isit;
    }

    public void setIsOwned(bool isit) {
        isOwned = isit;
    }
}
