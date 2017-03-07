using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDrawer : MonoBehaviour {

    public GameObject Rdrawer = null;
    public float openDistance = 8.0f;
    public bool isOpen = false;
    public bool canOpen = true;

    private void Awake() {
        Rdrawer = GameObject.Find("rightDrawer");
    }

    public void onRDrawerOpen() {
        if (canOpen == true) {
            Debug.Log("Drawer Open");
            isOpen = true;
            canOpen = false;
            Vector3 pos = Rdrawer.transform.position;
            pos.y -= openDistance;
            Rdrawer.transform.position = pos;
        } else {
            Debug.Log("Drawer Close");
            isOpen = false;
            canOpen = true;
            Vector3 pos = Rdrawer.transform.position;
            pos.y -= -openDistance;
            Rdrawer.transform.position = pos;
        }
    }
}
