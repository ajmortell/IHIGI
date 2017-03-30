using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour {

    private GameObject map;
    private float mapX;
    private float mapY;
    private RectTransform mapSize;
    private List<GridTile> tiles;

    // Use this for initialization
    void Awake () {
        
        map = GameObject.FindGameObjectWithTag("Map");
        mapSize = map.GetComponent<RectTransform>();
        Vector2 size = mapSize.rect.size;


        tiles = new List<GridTile>();

        CollectGridTiles();
    }

    public void CollectGridTiles()
    {
        GameObject[] gridTileObjects = GameObject.FindGameObjectsWithTag("GridTile");
        foreach (GameObject tileObj in gridTileObjects) {
            AddGridTile(tileObj.GetComponent<GridTile>());
        }
    }

    public void AddGridTile(GridTile tile) {
        tiles.Add(tile);
        print("TILE COUNT: " + tiles.Count);
    }

    public void OnGridManager() {
        print("....... OnGridManager ........");
    }
	
	void Update () {
        
	}

}
