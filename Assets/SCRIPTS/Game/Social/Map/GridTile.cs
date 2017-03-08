using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridTile : MonoBehaviour {

    private float width;
    private float height;
    private int tileId;

    public GameObject self = null;

    private Image tileImage;

    private NPC npc;
    private List<GameObject> npcsInArea;

    private GameObject map;
    private float mapX;
    private float mapY;
    private RectTransform mapSize;

    void Awake () {
        self = gameObject;
        map = GameObject.FindGameObjectWithTag("Map");
        mapSize = map.GetComponent<RectTransform>();
        Vector2 size = mapSize.rect.size;
        //print("MAP SIZE: " + size + " NAME: " + map.name);

        tileImage = self.GetComponent<Image>();
        tileImage.color = Color.clear;
    }

    IEnumerator Fader() {
        tileImage.color = Color.magenta;
        tileImage.CrossFadeAlpha(0, 0.5f, false);
        yield return new WaitForSeconds(0.5f);
        tileImage.CrossFadeAlpha(1, 0.5f, false);

    }
	
    public void OnClick() { 
        StartCoroutine(Fader());
    }
	
}
