using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour {

    private GameObject LeftDrawer = null;
    private GameObject RightDrawer = null;
    private float openDistance = 8.0f;
    private bool isLDOpen = false;
    private bool canLDOpen = true;
    private bool isRDOpen = false;
    private bool canRDOpen = true;

    private void Awake() {
        LeftDrawer = GameObject.Find("leftDrawer");
        RightDrawer = GameObject.Find("rightDrawer");
    }

    public void OnLeftDrawerOpen() {
        if (canLDOpen == true) {
            isLDOpen = true;
            canLDOpen = false;
            Vector2 pos = LeftDrawer.transform.position;
            pos.y -= openDistance;
            LeftDrawer.transform.position = pos;
        } else {
            isLDOpen = false;
            canLDOpen = true;
            Vector2 pos = LeftDrawer.transform.position;
            pos.y -= -openDistance;
            LeftDrawer.transform.position = pos;
        }
    }

    public void OnRightDrawerOpen() {
        if (canRDOpen == true) {
            isRDOpen = true;
            canRDOpen = false;
            Vector2 pos = RightDrawer.transform.position;
            pos.y -= openDistance;
            RightDrawer.transform.position = pos;
        } else {
            isRDOpen = false;
            canRDOpen = true;
            Vector2 pos = RightDrawer.transform.position;
            pos.y -= -openDistance;
            RightDrawer.transform.position = pos;
        }
    }
}
