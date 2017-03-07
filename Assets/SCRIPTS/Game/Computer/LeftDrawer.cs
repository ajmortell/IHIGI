using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDrawer : MonoBehaviour {

    public GameObject Ldrawer = null;
    public float openDistance = 8.0f;
    public bool isOpen = false;
    public bool canOpen = true;

    private void Awake() {
        Ldrawer = GameObject.Find("leftDrawer");
    }

    public void onLDrawerOpen() {
        if (canOpen == true) {
            Debug.Log("onDrawerOpen");
            isOpen = true;
            canOpen = false;
            Vector3 pos = Ldrawer.transform.position;
            pos.y -= openDistance;
            Ldrawer.transform.position = pos;
        } else {
            Debug.Log("onDrawerClose");
            isOpen = false;
            canOpen = true;
            Vector3 pos = Ldrawer.transform.position;
            pos.y -= -openDistance;
            Ldrawer.transform.position = pos;
        }
    }
}
