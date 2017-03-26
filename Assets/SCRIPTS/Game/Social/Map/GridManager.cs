using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    private GameObject map;
    private float mapX;
    private float mapY;
    private RectTransform mapSize;
    private List<GameObject> tiles;

    // Use this for initialization
    void Awake () {
        
        map = GameObject.FindGameObjectWithTag("Map");
        mapSize = map.GetComponent<RectTransform>();
        Vector2 size = mapSize.rect.size;
        //print("MAP SIZE: " + size + " NAME: " + map.name);
    }

    public void OnGridManager() {
        print("....... OnGridManager ........");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
