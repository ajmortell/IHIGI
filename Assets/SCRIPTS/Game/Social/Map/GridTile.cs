using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridTile : MonoBehaviour {

    private float tileWidth;
    private float tileHeight;
    private RectTransform tileSize;

    private bool tileClicked;
    
    public GameObject self = null;

    private Animator anim;
    private SpriteRenderer scannerSprite;

    void Awake () {
        tileClicked = false;

        self = gameObject;

        scannerSprite = self.GetComponentInChildren<SpriteRenderer>();
        scannerSprite.material.color = Color.clear;
        anim = scannerSprite.GetComponent<Animator>();
        
        tileSize = self.GetComponent<RectTransform>();

        Vector2 size = tileSize.rect.size;

        tileWidth = size.x;
        tileHeight = size.y;
    }

    IEnumerator AnimateScanner() {
        
        scannerSprite.material.color = Color.cyan;
        yield return new WaitForSeconds(0.5f);
    }
	
    public void OnClick() {
        tileClicked = true;
        Vector2 size = tileSize.rect.size;
        print("TILE WIDTH: " + tileWidth + " TILE HEIGHT: " + tileHeight + " TOTAL SIZE: " + size);
        anim.SetBool("scanON", true);
        StartCoroutine(AnimateScanner());
    }

    void Update() {

        if (tileClicked == true) {
            tileClicked = false;
            print("tile clicked");
            GameObject managerobj = GameObject.FindGameObjectWithTag("Map");
            GridManager manager = managerobj.GetComponent<GridManager>();
            manager.OnGridManager();
        }
    }

}
