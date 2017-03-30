using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//// Rewind 2

public class GridTile : MonoBehaviour {

    private Transform tileTransform;
    private float tileWidth;
    private float tileHeight;
    private RectTransform tileSize;
    private Scanner scanner;
    private bool tileClicked;
    
    public GameObject self = null;

    void Awake () {
        tileClicked = false;
        tileTransform = transform;
        self = gameObject;
        tileSize = self.GetComponent<RectTransform>();
        Vector2 size = tileSize.rect.size;
        tileWidth = size.x;
        tileHeight = size.y;
       scanner = gameObject.GetComponent<Scanner>();
    }

    public Transform getTileTransform() {

        return tileTransform;
    }
 
    public void OnClick() {
        tileClicked = true;
        
        scanner.OnScan();
    }

    void Update() {

        if (tileClicked == true) {
            tileClicked = false;
            print("tile clicked");
        }
    }

}
